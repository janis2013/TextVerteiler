using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace TextVerteiler.Networking
{
    public class ServerContext
    {

        public TcpListener listener { get; private set; }


        public IPAddress Ip { get; set; }


        public int Port { get; set; }


        public List<ClientContext> Clients { get; set; }

        public int MaxClients { get; set; }

        private List<string> TextStack = new List<string>();


        AsyncCallback BeginAcceptSocketCallback;

        public ServerContext(int port, int maxclients, ref List<string> TextStack)
        {

            MaxClients = maxclients;

            Ip = IPAddress.Any;
            this.Port = port;

            listener = new TcpListener(Ip, Port);
            Clients = new List<ClientContext>(MaxClients);

            listener.Start();

            BeginAcceptSocketCallback = new AsyncCallback(OnClientConnected);

            this.TextStack = TextStack;
        }


        public void DoListen()
        {

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);


            listener.BeginAcceptSocket(BeginAcceptSocketCallback, null);

        }

        public void OnClientConnected(IAsyncResult _ClientSocket)
        {

            if (this.Clients.Count <= MaxClients - 1)
            {

                Socket clientsocket = listener.EndAcceptSocket(_ClientSocket);

                ClientContext clientcontext = new ClientContext(clientsocket);

                this.Clients.Add(clientcontext);

                //listen for next
                DoListen();

            }
            else
            {
                //keine mehr annehmen
            }

        }

        public void DisconnectAllClients()
        {
            foreach (var client in this.Clients)
            {
                if (client.socket.Connected)
                {
                    client.socket.Close();
                }
            }
        }

        public int GetRealClientsCount()
        {
            int count = Clients.Count;
            int clientsCount = 0;

            for (int i = 0; i < count; i++)
            {
                if (this.Clients[i].isConnected())
                {
                    clientsCount++;
                }
                else
                {
                    //delete
                    this.Clients[i].Close();
                    this.Clients.RemoveAt(i);
                    i--;
                    count = this.Clients.Count;
                }
            }

            return clientsCount;

        }

        public void SendText(string Text)
        {
            if (Clients.Count > 0)
            {

                byte[] message = Text.ToByteArray();


                foreach (var client in this.Clients)
                {
                    if (client.socket.IsBound)
                    {
                        client.Send(message);
                    }
                }
            }

            if (this.TextStack.Count() < FormMain.HistoryStackSize)
            {
                this.TextStack.Add(Text);
            }
            else if (this.TextStack.Count() >= FormMain.HistoryStackSize)
            {
                //am anfang löschen bis passt
                while (this.TextStack.Count() >=  FormMain.HistoryStackSize)
                {
                    this.TextStack.RemoveAt(0);
                }

                this.TextStack.Add(Text);
            }



        }




    }
}

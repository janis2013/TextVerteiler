using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Net.Security;

namespace TextVerteiler.Networking
{
    public class ClientContext
    {
        public Socket socket { get; set; }

        private AsyncCallback BeginSendToCallback;


        public ClientContext(Socket AcceptedSocket)
        {
            this.socket = AcceptedSocket;
            socket.SendBufferSize = 1024;

            BeginSendToCallback = new AsyncCallback(OnSendToFinished);

        }

        public void Send(string Text)
        {
            byte[] bytes = Text.ToByteArray();
            int result = 0;

            this.socket.BeginSendTo(bytes, 0, bytes.Length, SocketFlags.None, socket.RemoteEndPoint, BeginSendToCallback, result);
        }


        public void Send(byte[] Text)
        {
            try
            {

                int result = 0;

                //wenn der receivepuffer überschritten wird, wird nur das ende der naricht geschickt...
                if (this.socket.Connected)
                {
                    this.socket.BeginSendTo(Text, 0, Text.Length, SocketFlags.None, socket.RemoteEndPoint, BeginSendToCallback, result);
                  
                }
            }
            catch (Exception)
            {
            }
        }


        private void OnSendToFinished(IAsyncResult result)
        {
            int gesendeteBytesAnzahl = this.socket.EndSendTo(result);
        }

        public bool isConnected()
        {
            if (socket != null && socket.Connected)
            {
                bool part1 = socket.Poll(1000, SelectMode.SelectRead);
                bool part2 = (socket.Available == 0);
                if (part1 & part2)
                    return false;
                else
                    return true;
            }
            else
            {
                return false;
            }
        }

        public void Close()
        {
            try
            {
                socket.Close();
            }
            catch (Exception e)
            {

                throw;
            }
        }

    }

    public static class ExtendString
    {

        public static byte[] ToByteArray(this string Text)
        {
            return System.Text.Encoding.Unicode.GetBytes(Text);
        }

    }
}

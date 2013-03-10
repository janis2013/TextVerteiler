/*
 * 
 * This Program is free for ANY use.
 * 
 * 
 * Program written by Janis Dähne
 * 
 * 
 * To change network stuff
 * change port: Port
 * 
 * 
*/







using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TextVerteiler.Networking;
using System.Net;
using System.Net.Sockets;

namespace TextVerteiler
{
    public partial class FormMain : Form
    {


        public ServerContext Server { get; set; }

        private int Port = 8008;


        public bool IfLostFocus { get; set; }

        public bool IfButtonClicked { get; set; }

        public bool IfTimespanElapsed { get; set; }

        public int Zeitspanne { get; set; }

        public int TimeCount { get; set; }

        private int Pointer = 0;

        List<string> TextHistory = new List<string>();


        public static double LeaveOpacity = 0.3D;

        public int CheckStatusCounter { get; set; } //0 to 10


        public int LazyCounter { get; set; }//nach XX sec automatisch verstecken

        public int MaxLazy { get; set; }

        public static int HistoryStackSize { get; set; }

        public long NarichtenCounter { get; set; }


        public FormMain()
        {
            InitializeComponent();

            //Program.fmEinstellungen.Show();
            //Program.fmEinstellungen.Visible = false;

            Program.fmEinstellungen.InitFormEinstellungen();

            this.IfButtonClicked = true;
            this.Zeitspanne = 1000;

        }



        private void FormMain_Load(object sender, EventArgs e)
        {
            ResetPosition();

        }

        public void IniFormMain()
        {
            this.TopMost = true;
            ResetPosition();

            FormMain.HistoryStackSize = 20;

            try
            {
                tbMessage.LostFocus += new EventHandler(tbMessage_LostFocus);

                IPHostEntry r = Dns.GetHostEntry(IPAddress.Loopback);

                var result = r.AddressList.Where((ipadd) => ipadd.AddressFamily == AddressFamily.InterNetwork).ToList();

                if (result.Count >= 1)
                {

                    tbMessage.Text = "Eigene IP: " + result[0].ToString();// +" : " + Port.ToString();

                }


                Server = new ServerContext(Port, 50, ref TextHistory);

                Server.DoListen();

            }
            catch (Exception m)
            {
                MessageBox.Show(m.Message);
            }
            SetLeaveOpacity();

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIconFmMain.ShowBalloonTip(10);
            this.Visible = false;
            e.Cancel = true;
        }

        public void ResetPosition()
        {
            Point p = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width,
                   Screen.PrimaryScreen.WorkingArea.Bottom - this.Height);
            //((Screen.PrimaryScreen.Bounds.Bottom - Screen.PrimaryScreen.WorkingArea.Bottom) = taskbar height);
            this.Location = p;
        }


        [System.Diagnostics.DebuggerHidden()]
        void tbMessage_LostFocus(object sender, EventArgs e)
        {
            if (this.IfLostFocus)
            {
                if (tbMessage.Text != "")
                {
                    Server.SendText(tbMessage.Text);
                    NarichtenCounter++;
                    lbStatus.Text = "Gesendet: " + DateTime.Now.ToShortTimeString() + " - Naricht " + NarichtenCounter;
                    if (TextHistory.Count == 2)
                    {
                        Pointer = TextHistory.Count - 1;
                        btnPrevious.Enabled = true;
                    }
                    else if (TextHistory.Count > 2)
                    {
                        Pointer = TextHistory.Count - 1;
                        btnPrevious.Enabled = true;
                        btnNext.Enabled = false;
                    }
                }

                //Server.SendText(tbMessage.Text);
                //this.Text = "Text Input - " + Server.GetRealClientsCount() + " received";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (this.IfButtonClicked)
            {
                if (tbMessage.Text != "")
                {
                    Server.SendText(tbMessage.Text);
                    NarichtenCounter++;
                    lbStatus.Text = "Gesendet: " + DateTime.Now.ToShortTimeString() + " - Naricht " + NarichtenCounter;
                    if (TextHistory.Count == 2)
                    {
                        Pointer = TextHistory.Count - 1;
                        btnPrevious.Enabled = true;
                    }
                    else if (TextHistory.Count > 2)
                    {
                        Pointer = TextHistory.Count - 1;
                        btnPrevious.Enabled = true;
                        btnNext.Enabled = false;
                    }
                }

            }

        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            if (tbMessage.Text == "")
            {
                btnSend.Enabled = false;
            }
            else
            {
                btnSend.Enabled = true;
            }
            if (this.IfTimespanElapsed)
            {
                this.TimeCount = 0;
                timer1.Start();
            }
        }

        public void SetFormText(string Text)
        {
            if (this.InvokeRequired)
            {
                Action<string> set = new Action<string>(SetFormText);
                this.Invoke(set, new object[] { Text });
            }
            else
            {
                this.Text = Text;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimeCount >= this.Zeitspanne / timer1.Interval)
            {

                if (tbMessage.Text != "")
                {
                    Server.SendText(tbMessage.Text);
                    NarichtenCounter++;
                    lbStatus.Text = "Gesendet: " + DateTime.Now.ToShortTimeString() + " - Naricht " + NarichtenCounter;
                    if (TextHistory.Count == 2)
                    {
                        Pointer = TextHistory.Count - 1;
                        btnPrevious.Enabled = true;
                    }
                    else if (TextHistory.Count > 2)
                    {
                        Pointer = TextHistory.Count - 1;
                        btnPrevious.Enabled = true;
                        btnNext.Enabled = false;
                    }
                }

                this.TimeCount = 0;
                timer1.Stop();
            }
            TimeCount++;
        }



        public void Shutdown()
        {
            Server.DisconnectAllClients();
            notifyIconFmMain.Dispose();
            Program.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Pointer++;
            SetTextFromHistory();

            if (Pointer == TextHistory.Count - 1)
            {
                btnNext.Enabled = false;
                btnPrevious.Enabled = true;
            }
            else
            {
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Pointer--;
            SetTextFromHistory();

            if (Pointer == 0)
            {
                btnPrevious.Enabled = false;
                btnNext.Enabled = true;
            }
            else
            {
                btnPrevious.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        private void SetTextFromHistory()
        {
            if (Pointer >= 0 && Pointer < this.TextHistory.Count)
            {
                this.tbMessage.Clear();
                tbMessage.Text = this.TextHistory[Pointer];
                tbMessage.SelectAll();
            }

        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                tbMessage.SelectAll();
            }
        }


        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.fmEinstellungen.Visible = true;
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shutdown();
        }

        private void notifyIconFmMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.Visible == true)
                {
                    this.Visible = false;
                }
                else
                {
                    this.Visible = true;
                }

            }
        }

        #region Opacity


        private void SetEnterOpacity()
        {
            this.Opacity = 1.0;
        }

        private void SetLeaveOpacity()
        {
            this.Opacity = LeaveOpacity;
        }

        #endregion

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {

            if (this.DesktopBounds.IntersectsWith(new Rectangle(Cursor.Position.X, Cursor.Position.Y, 1, 1)))
            {
                SetEnterOpacity();
                LazyCounter = 0;
            }
            else
            {
                SetLeaveOpacity();

                //nur wenn fenster auch wirklich sichtbar
                if (this.Visible == true)
                {
                    if (LazyCounter >= MaxLazy && MaxLazy > 0)
                    {
                        this.Visible = false;
                        LazyCounter = 0;
                    }

                    if (MaxLazy > 0)
                    {
                        LazyCounter++;
                    }
                    else
                    {
                        LazyCounter = 0;
                    }
                }
                
               
            }

            if (this.CheckStatusCounter >= 10) // 1 sekunde (intervall 100 * 10)
            {
                this.Text = "Text Input - " + Server.GetRealClientsCount() + " connected";
                this.CheckStatusCounter = 0;
            }

            this.CheckStatusCounter++;



        }

    }
}

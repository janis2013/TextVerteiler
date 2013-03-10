using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TextVerteiler
{
    public partial class FormEinstellungen : Form
    {


        ToolTip tip1 = new ToolTip();
        ToolTip tip2 = new ToolTip();
        ToolTip tip3 = new ToolTip();

        ToolTip[] Tips;


        public FormEinstellungen()
        {
            InitializeComponent();

        }


        private void FormEinstellungen_Load(object sender, EventArgs e)
        {

        }

        public void InitFormEinstellungen()
        {
            numZeitspanne_ValueChanged(this, new EventArgs());
            checkBoxByClicked.Checked = true;

            Tips = new ToolTip[] { tip1, tip2 , tip3};

            foreach (var tip in Tips)
            {
                tip.UseFading = false;
                tip.UseAnimation = false;
                tip.ShowAlways = false;
                tip.InitialDelay = 500;
            }

            tip1.SetToolTip(checkBoxByZeitspanne, "Startet, wenn sich der Text in der Textbot ändert.\n" +
                "Hinweis: Startet auch, wenn der History Stack benutzt wird!");

            tip2.SetToolTip(numHistoryStack, "Gibt an, wie viele Narichten zwischengespeichert werden.");

            tip3.SetToolTip(numAutomatischVerstecken, "Startet, wenn die Maus außerhalb des Fensters ist.");

            this.TopMost = true;
        }



        private void numZeitspanne_ValueChanged(object sender, EventArgs e)
        {
            if (Program.fmMain != null)
            {
                Program.fmMain.Zeitspanne = (int)numZeitspanne.Value;
            }

        }


        private void checkBoxByClicked_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.fmMain != null)
            {
                Program.fmMain.IfButtonClicked = checkBoxByClicked.Checked;
            }

        }

        private void checkBoxByLostFocus_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.fmMain != null)
            {
                Program.fmMain.IfLostFocus = checkBoxByLostFocus.Checked;
            }

        }

        private void checkBoxByZeitspanne_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.fmMain != null)
            {
                Program.fmMain.IfTimespanElapsed = checkBoxByZeitspanne.Checked;
            }

        }

        private void FormEinstellungen_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Visible = false;
            e.Cancel = true;
        }

        private void numOpcaity_ValueChanged(object sender, EventArgs e)
        {
            FormMain.LeaveOpacity = (double)numOpcaity.Value;
        }

        private void btnResetPosition_Click(object sender, EventArgs e)
        {
            Program.fmMain.ResetPosition();
        }

        private void numAutomatischVerstecken_ValueChanged(object sender, EventArgs e)
        {
            Program.fmMain.MaxLazy = (int)numAutomatischVerstecken.Value * 10;
        }

        private void numHistoryStack_ValueChanged(object sender, EventArgs e)
        {
            FormMain.HistoryStackSize = (int)numHistoryStack.Value;
        }




    }
}

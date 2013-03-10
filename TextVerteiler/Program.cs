using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TextVerteiler
{
    static class Program
    {

        public static FormMain fmMain;
        public static FormEinstellungen fmEinstellungen;


        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            fmEinstellungen = new FormEinstellungen();
            fmMain = new FormMain();

            fmMain.IniFormMain();

            Application.Run();
        }


        public static void Exit()
        {
            Application.ExitThread();
        }
    }
}

using Otel_Uygulamasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DevExpress_Deneme
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool prog;
            Mutex mtx = new Mutex(true, "asd", out prog);
            if (!prog)
            {
                MessageBox.Show(Localization.ProgramCalisiyorHata, "HoteliEU", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            GC.KeepAlive(mtx);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}

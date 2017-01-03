
using System;
using System.Windows.Forms;

namespace EdoUI.Entidades.DTOEdoUI
{
    public static class RunEdo
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
}

using ControlDependencia;
using System;
using System.Windows.Forms;

namespace EdoUI
{
    public class StartEdo : IStartEdo
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        public void Run()
        {
            Main();
        }
    }
}

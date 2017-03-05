using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;

namespace EdoUI
{
    public partial class ProbarConexion : UserControl
    {
        private delegate void SetTextCallback(string text);
        private System.Timers.Timer iTimer;

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int Reserved);

        public ProbarConexion()
        {
            InitializeComponent();

            this.iTimer = new System.Timers.Timer(300000); //5 min
            this.iTimer.Elapsed += new ElapsedEventHandler(iTimer_Elapsed);
            this.iTimer.Enabled = true;
        }

        public static bool ObtenerEstadoConexion()
        {
            int Descript;
            return InternetGetConnectedState(out Descript, 0);
        }

        private void iTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.SetText(ObtenerEstadoConexion() ? "Conectado" : "Sin Conexion");
        }

        private void SetText(string pTexto)
        {
            if (this.ss_Main.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { pTexto });
            }
            else
            {
                this.tlsl_Main_Conexion.Text = pTexto;
            }
        }
    }
}

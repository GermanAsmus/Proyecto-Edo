using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;
using System.Threading;
using System.Timers;
using Utilidades.Internet;

namespace EdoUI
{
    public partial class BloqueUtilidad : UserControl
    {
        delegate void SetTextCallback(string text);

        static System.Timers.Timer iTimer;
        public BloqueUtilidad()
        {
            InitializeComponent();
            iTimer = new System.Timers.Timer(5000);
            iTimer.Elapsed += new ElapsedEventHandler(iTimer_Elapsed);
            iTimer.Enabled = true;
        }

        private void iTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.SetText(VerificarConexion.ObtenerEstadoConexion() ? "Conectado" : "Sin Conexion");
        }
        private void SetText(string pTexto)
        {
            if (this.label2.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { pTexto });
            }
            else
            {
                label2.Text = pTexto;
            }
        }

    }
}

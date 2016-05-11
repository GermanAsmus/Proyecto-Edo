using ControlDependencia;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Utilidades;
using Utilidades.Internet;

namespace EdoUI
{
    public partial class EDO : Form
    {
        delegate void SetTextCallback(string text);
        static System.Timers.Timer iTimer;

        PanelPrincipal controlPanelPrincipal;

        public EDO()
        {
            InitializeComponent();

            controlPanelPrincipal = new PanelPrincipal() { Dock = DockStyle.Fill };
            controlPanelPrincipal.ContainerChanged += ContainerHasChanged;
            controlPanelPrincipal.ContainerIsDisposed += ContainerHasBeenDisposed;
            panelPrincipal.Controls.Add(controlPanelPrincipal);

            iTimer = new System.Timers.Timer(5000);
            iTimer.Elapsed += new ElapsedEventHandler(iTimer_Elapsed);
            iTimer.Enabled = true;
        }

        private void ContainerHasChanged()
        {
            if (this.controlPanelPrincipal.contenedorPanel.IsDisposed && this.panelA.Controls.Count == 0)
                panelA.Controls.Add(this.controlPanelPrincipal.contenedorPanel.Controls[0]);
        }

        private void ContainerHasBeenDisposed()
        {
            if (this.controlPanelPrincipal.contenedorPanel.IsDisposed && this.panelA.Controls.Count > 0)
                panelA.Controls.RemoveAt(0);
        }
        private void iTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.SetText(VerificarConexion.ObtenerEstadoConexion() ? "Conectado" : "Sin Conexion");
        }
        private void SetText(string pTexto)
        {
            if (this.statusStripConexion.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { pTexto });
            }
            else
            {
                this.toolStripStatusLabelConexion.Text = pTexto;
            }
        }
    }
}

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
using System.Windows.Forms;


namespace EdoUI
{
    public partial class EDO : Form
    {
        PanelPrincipal controlPanelPrincipal;
        public EDO()
        {
            InitializeComponent();

            controlPanelPrincipal = new PanelPrincipal() { Dock = DockStyle.Fill };
            //controlPanelPrincipal.ContainerChanged += ControlPanelPrincipal_ContainerAChanged;
            //controlPanelPrincipal.ContainerDisposed += ControlPanelPrincipal_ContainerADisposed;
            controlPanelPrincipal.ContainerChanged += ContainerHasChanged;
            controlPanelPrincipal.ContainerIsDisposed += ContainerHasBeenDisposed;
            panelPrincipal.Controls.Add(controlPanelPrincipal);
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

        //private void ControlPanelPrincipal_ContainerAChanged(object sender, EventArgs e)
        //{
        //    if (this.controlPanelPrincipal.contenedorPanel.IsDisposed && this.panelA.Controls.Count == 0)
        //        panelA.Controls.Add(this.controlPanelPrincipal.contenedorPanel.Controls[0]);
        //}

        //private void ControlPanelPrincipal_ContainerADisposed(object sender, EventArgs e)
        //{
        //    if (this.controlPanelPrincipal.contenedorPanel.IsDisposed && this.panelA.Controls.Count > 0)
        //        panelA.Controls.RemoveAt(0);
        //}
    }
}

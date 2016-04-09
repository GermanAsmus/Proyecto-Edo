using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlDependencia;

namespace EdoUI
{
    public delegate void ContainerChangedEventHandler(object sender, EventArgs e);

    public delegate void ContainerDisposedEventHandler(object sender, EventArgs e);


    public partial class PanelPrincipal : UserControl
    {

        public Action ContainerChanged;
        public Action ContainerIsDisposed;

        public Control contenedorPanel { get; }

        public PanelPrincipal()
        {
            InitializeComponent();
            contenedorPanel = new Control();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            contenedorPanel.Dispose();
            ContainerIsDisposed();
        }

        private void buttonCuenta_Click(object sender, EventArgs e)
        {
            contenedorPanel.Dispose();
            ContainerIsDisposed();

            //contenedorPanel.Controls.Add(new RichTextBox() { Dock = DockStyle.Fill, Text = "EN MANTENIMIENTO...", Enabled = false });
            contenedorPanel.Controls.Add(new ControlRaiz() { Dock = DockStyle.Fill });
            ContainerChanged();
        }
    }
}

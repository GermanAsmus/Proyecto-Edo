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
using Modelo;
using ControlDependencia.Dominio;

namespace EdoUI
{
    public partial class ControlRaiz : UserControl
    {
        private IControlador iControlador;

        public ControlRaiz()
        {
            InitializeComponent();
            tabControlContenedor.ImageList = imageList1;
            //iControlador = IoCContenedor.Resolver<IControlador>();

            AgregarTab(new PictureBox() { Name="Primeros Pasos" });
        }
        private void AgregarTab(Control pControl)
        {

            TabPage tb = new TabPage(pControl.Name);
            tb.ImageIndex = 0;
            pControl.Dock = DockStyle.Fill;
            tb.Controls.Add(pControl);
            tabControlContenedor.TabPages.Add(tb);
        }
        private void toolStripButtonNuevaCuenta_Click(object sender, EventArgs e)
        {
            AgregarTab(new ControlCuenta(ref iControlador) { Name = "Nueva Cuenta" });
        }

        private void toolStripComboBoxCuenta_Click(object sender, EventArgs e)
        {
            //this.toolStripComboBoxCuenta.Items.AddRange(this.iControlador.ObtenerTodasLasCuentas().Select(x => x.Nombre).ToArray());
        }

        private void toolStripComboBoxCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

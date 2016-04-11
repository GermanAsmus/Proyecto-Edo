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

namespace EdoUI
{
    public partial class ControlRaiz : UserControl
    {
        private IControlador controlador;
        private IEnumerable<Cuenta> iCuentas;
        private IEnumerable<Servidor> iServidores = null;

        public ControlRaiz()
        {
            InitializeComponent();

            controlador = IoCContenedor.Resolver<IControlador>();

            TabPage tb = new TabPage("Primeros Pasos");
            tb.Controls.Add(new RichTextBox() { Text = "Bienvenido", Dock = DockStyle.Fill });
            tabControlContenedor.TabPages.Add(tb);
        }
        private async Task ObtenerServicios()
        {
            //Se cargan los servidores solo la primera vez
            //la coleccion de servidores no cambia, ya está definida anteriormente
            if (iServidores == null)
            {
                var sevicioServidor = (IServicio<Servidor>)controlador.iGestor.ObtenerServicio(typeof(Servidor));
                iServidores = await sevicioServidor.ObtenerTodos();
            }
        }
        private async void toolStripButtonNuevaCuenta_Click(object sender, EventArgs e)
        {
            await ObtenerServicios();
            Control nuevaCuenta = new ControlCuenta(iServidores, ref controlador) { Name = "Nueva Cuenta", Dock = DockStyle.Fill };
            AgregarControl(nuevaCuenta);
        }

        private void AgregarControl(Control pControl)
        {
            TabPage tab = new TabPage(pControl.Name) { Name = pControl.Name };
            tab.Controls.Add(pControl);
            tabControlContenedor.TabPages.Add(tab);
        }

        private async void toolStripComboBoxCuenta_Click(object sender, EventArgs e)
        {
            var servicioCuenta = (IServicio<Cuenta>)this.controlador.iGestor.ObtenerServicio(typeof(Cuenta));

            iCuentas = await servicioCuenta.ObtenerTodos();
            iCuentas.ToList().ForEach(x =>
            {
                if (!toolStripComboBoxCuenta.Items.Contains(x.CuentaId))
                    toolStripComboBoxCuenta.Items.Add(x.CuentaId);

            });
        }

        private void toolStripComboBoxCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cuentaSeleccionada = ((ToolStripComboBox)sender).SelectedItem.ToString();
            if (!tabControlContenedor.TabPages.ContainsKey(cuentaSeleccionada))
                AgregarControl(new BloqueCuenta(iCuentas.First(x => x.CuentaId == cuentaSeleccionada)) { Name = cuentaSeleccionada, Dock = DockStyle.Fill });

        }
    }
}

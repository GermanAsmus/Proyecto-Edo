using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaInterfaces;
using Modelo;
using CapaInterfaces.Modelo;

namespace EdoUI
{
    public partial class ControlRaiz : UserControl
    {
        private IControlador iControlador;
        private BandejaCuentas iBandejaCuentas;

        public ControlRaiz()
        {
            InitializeComponent();
            tabControlContenedor.ImageList = imageList1;
            //iControlador = IoC_CL.Resolver<IControlador>();


            this.iBandejaCuentas = new BandejaCuentas(null);
            AgregarTab(this.iBandejaCuentas, "Cuentas");

            //Cuando el controlador funcione debería listar las cuentas que están en la bbdd
            //this.iBandejaCuentas.ListarCuentas(this.iControlador.ListarCuentas());
        }

        private TabPage AgregarTab(Control pControl, string pNombre)
        {

            TabPage tb = new TabPage(pNombre);
            tb.ImageIndex = 0;
            pControl.Dock = DockStyle.Fill;
            tb.Controls.Add(pControl);
            tabControlContenedor.TabPages.Add(tb);
            return tb;
        }

        private void toolStripButtonNuevaCuenta_Click(object sender, EventArgs e)
        {
            ControlCuenta controlNuevaCuenta = new ControlCuenta(null);
            this.tabControlContenedor.SelectedTab = AgregarTab(controlNuevaCuenta, "Nueva Cuenta");
            controlNuevaCuenta.VisibleChanged += ControlNuevaCuenta_VisibleChanged;
        }

        private void ControlNuevaCuenta_VisibleChanged(object sender, EventArgs e)
        {
            ControlCuenta controlDeLaCuentaCreada = (sender as ControlCuenta);

            TabPage pestaniaPadreDelControl = controlDeLaCuentaCreada.Parent as TabPage;

            //Se obtiene la información de la nueva cuenta.
            ICuentaUsuarioDTO cuentaCreada = controlDeLaCuentaCreada.Cuenta;
            //La pestaña se cierra antes de mostrar el mensaje.
            pestaniaPadreDelControl.Dispose();

            // se guarda la nueva cuenta;
            //  this.iControlador.CrearCuentaNueva((sender as ControlCuenta).Cuenta);

            string mensaje = string.Format(
                @"La cuenta ha sido creada satisfactoriamente.
                {0}Los datos ingresados fueron: 
                {0}Nombre: {1},
                {0}Correo: {2},
                {0}Seleccione la pestaña cuentas para utilizar su nueva cuenta", Environment.NewLine, cuentaCreada.Nombre, cuentaCreada.DireccionCorreo.DireccionDeCorreo);
            MessageBox.Show(this, mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

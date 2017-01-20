using System;
using System.Windows.Forms;
using Dominio;
using Dominio.Entidades.Interfaces;

namespace EdoUI
{
    public partial class ControlRaiz : UserControl
    {
        private IControladorDominio iControlador;
        private Bandeja<ICuenta> iBandejaCuentas;

        public ControlRaiz()
        {
            InitializeComponent();
            tabControlContenedor.ImageList = imageList1;
            iControlador = DI.IoCContainer.Resolve<IControladorDominio>();
            
            this.iBandejaCuentas = new Bandeja<ICuenta>();
            AgregarTab(this.iBandejaCuentas, "Cuentas");

            //Cuando el controlador funcione debería listar las cuentas que están en la bbdd
            this.iBandejaCuentas.ListarCuentas(this.iControlador.ListarCuentas());

            ActualizarBandejaCuentas();
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

        private void NuevaCuenta_Click(object sender, EventArgs e)
        {
            ControlCuenta controlNuevaCuenta = new ControlCuenta(null);
            this.tabControlContenedor.SelectedTab = AgregarTab(controlNuevaCuenta, "Nueva Cuenta");
            controlNuevaCuenta.VisibleChanged += ControlNuevaCuenta_VisibleChanged;
        }
        /// <summary>
        /// Se actualiza la bandeja de cuentas
        /// </summary>
        private void ActualizarBandejaCuentas()
        {
            //Primero limpia la bandeja
            this.iBandejaCuentas.BandejaTablePanel.Controls.Clear();

            #region old
            //Agrega las cuentas a la bandeja
            //this.iControlador.ListarCuentas().ToList().ForEach(
            //    cuentaUsuario => this.iBandejaCuentas.iBandejaFlowPanel.Controls.Add(this.iBandejaCuentas.NuevoBloque(new string[]
            //    {
            //        cuentaUsuario.Nombre,
            //        cuentaUsuario.DireccionCorreo.DireccionDeCorreo
            //    }, cuentaUsuario)));

            #endregion

            //List<ICuenta> lista = new List<ICuenta>() { new Cuenta() { Nombre = " Nombre: German", DireccionCorreo = new DireccionCorreo("Direccion de correo: german@gmail.com") } };
            //lista.ForEach(
            //    cuentaUsuario => this.iBandejaCuentas.NuevoBloque(new string[]
            //    {
            //        cuentaUsuario.DireccionCorreo.DireccionDeCorreo,
            //        cuentaUsuario.Nombre
            //    }, cuentaUsuario));
        }

        private void ControlNuevaCuenta_VisibleChanged(object sender, EventArgs e)
        {
            ControlCuenta controlDeLaCuentaCreada = (sender as ControlCuenta);

            TabPage pestaniaPadreDelControl = controlDeLaCuentaCreada.Parent as TabPage;

            //Se obtiene la información de la nueva cuenta.
            ICuenta cuentaCreada = controlDeLaCuentaCreada.Cuenta;
            //La pestaña se cierra antes de mostrar el mensaje.
            pestaniaPadreDelControl.Dispose();

            // se guarda la nueva cuenta;
            //  this.iControlador.CrearCuentaNueva((sender as ControlCuenta).Cuenta);
            //this.ActualizarBandejaCuentas();

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

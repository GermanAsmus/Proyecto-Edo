using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EdoUI.DI;
using Dominio.Entidades.Interfaces;
using Dominio;

namespace EdoUI.Cuenta
{
    public partial class BandejaCuenta : UserControl
    {
        internal IControladorDominio iControlador;

        public BandejaCuenta()
        {
            InitializeComponent();
            this.iControlador = IoCContainer.Resolve<IControladorDominio>();
        }

        private void btn_NuevaCuenta_Click(object sender, EventArgs e)
        {
            using (FormCuenta form = new FormCuenta())
            {
                DialogResult r = form.ShowDialog();
                if (r == DialogResult.OK)
                {
                    MessageBox.Show(
                        String.Format(@"La cuenta fue creada satisfactoriamente:
                    Nombre: {0},
                    Dirección de correo: {1}", form.Nombre, form.Direccion));

                    //agregar la cuenta a la bd.
                    ICuenta nuevaCuenta = IoCContainer.Resolve<ICuenta>();
                        nuevaCuenta.Nombre = form.Nombre;
                        nuevaCuenta.NuevaDireccionDeCorreo(form.Direccion);
                        nuevaCuenta.Contraseña = form.Contrasenia;

                    this.iControlador.CrearCuentaNueva(nuevaCuenta);
                }
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            using (FormCuenta form = new FormCuenta())
            {
                //pasar datos de la cuenta.
                form.ModificarCuenta("","");

                DialogResult r = form.ShowDialog();
                if (r == DialogResult.OK)
                {
                    MessageBox.Show(
                        String.Format(@"La cuenta fue modificada satisfactoriamente:
                    Nombre: {0},
                    Dirección de correo: {1}", form.Nombre, form.Direccion));

                    //modificar los valores en la bd.
                    //this.iControlador.ActualizarInformacionCuentaSeleccionada();
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //cambiar la cuenta seleccionada.
        }
    }
}

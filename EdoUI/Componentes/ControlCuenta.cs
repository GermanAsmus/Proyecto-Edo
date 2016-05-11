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
using Dominio;
using ControlDependencia.Dominio;

namespace EdoUI
{
    public partial class ControlCuenta : UserControl
    {
        public Cuenta iNuevaCuenta { get; }
        private IControlador iControlador;
        private string iDireccion;

        public ControlCuenta(ref IControlador pControlador)
        {
            InitializeComponent();
            iNuevaCuenta = new Cuenta();
            iControlador = pControlador;
            //comboBoxServidores.Items.AddRange(this.iControlador.ObtenerTodosLosServidores().Select(x => x.Nombre).ToArray());
        }

        private void toolStripButtonAceptar_Click(object sender, EventArgs e)
        {
            //if (comboBoxServidores.SelectedItem == null)
            //    MessageBox.Show("No ha seleccionado el servidor");
            //else
            //{
            //    DireccionCorreo iDireccionCorreo = this.iControlador.ObtenerDireccionDeCorreo(this.iDireccion);
            //    if (iDireccionCorreo == null)
            //    {
            //        iDireccionCorreo = new DireccionCorreo()
            //        {
            //            DireccionDeCorreo = this.iDireccion,
            //        };
            //    }
            //    Servidor iServidor = this.iControlador.ObtenerServidor(comboBoxServidores.SelectedItem.ToString());
            //    this.iControlador.AregarCuenta(iDireccionCorreo, iNuevaCuenta, iServidor);
            //    Parent.Dispose();
            //}
            Parent.Dispose();

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            //iNuevaCuenta.Nombre = textBoxNombre.Text;
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            //iDireccion = textBoxDireccion.Text;
        }

        private void textBoxContrasenia2_TextChanged(object sender, EventArgs e)
        {
            //if (string.Compare(textBoxContrasenia.Text, textBoxContrasenia2.Text) > 0)
            //    textBoxContrasenia.ForeColor = Color.Red;
            //else if (string.Equals(textBoxContrasenia.Text, textBoxContrasenia2.Text))
            //{
            //    textBoxContrasenia.ForeColor = Color.Green;
            //    iNuevaCuenta.Contraseña = textBoxContrasenia.Text;
            //}
        }
    }
}


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
    public partial class ControlCuenta : UserControl
    {
        public Cuenta nuevaCuenta { get; }
        private IServicio<Cuenta> servicioCuenta;
        public ControlCuenta(IServicio<Cuenta> servicio)
        {
            InitializeComponent();
            nuevaCuenta = new Cuenta();
            servicioCuenta = servicio;
            IServicio<Servidor> servicioServidores = (IServicio<Servidor>)servicioCuenta.GestorServicio.ObtenerServicio(typeof(Servidor));
            comboBoxServidores.Items.AddRange(servicioServidores.ObtenerTodos().Select(x => x.Nombre).ToArray());
        }

        private void toolStripButtonAceptar_Click(object sender, EventArgs e)
        {
            if (comboBoxServidores.SelectedItem == null)
                MessageBox.Show("No ha seleccionado el servidor");
            else
            {
                nuevaCuenta.ServidorId = comboBoxServidores.SelectedItem.ToString();
                Validate();
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            nuevaCuenta.CuentaId = textBoxNombre.Text;
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            nuevaCuenta.DireccionId = textBoxDireccion.Text;
        }

        private void textBoxContrasenia2_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(textBoxContrasenia.Text, textBoxContrasenia.Text) > 0)
                textBoxContrasenia.ForeColor = Color.Red;
            else
                textBoxContrasenia.ForeColor = Color.Green;
        }
    }
}

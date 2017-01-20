using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ControlDependencia;
using Persistencia;
//using CapaInterfaces.Modelo;
//using ControlDependencia.Dominio;

namespace EdoUI
{
    public partial class ControlCuenta : UserControl
    {

        public ICuenta Cuenta { get; set; }

        public ControlCuenta(string[] pNombreServidores)
        {
            InitializeComponent();
            //this.Cuenta = new Cuenta();


            if (pNombreServidores != null)
                this.comboBoxServidores.Items.AddRange(pNombreServidores);
        }

        private void toolStripButtonAceptar_Click(object sender, EventArgs e)
        {
            if (!this.CamposObligatoriosCompletos())
                MessageBox.Show("Faltan completar campos obligatorios");
            else
            {
                this.Cuenta.Nombre = textBoxNombre.Text;

                //this.Cuenta.DireccionCorreo = new DireccionCorreo(textBoxDireccion.Text);

                if (string.Equals(textBoxContrasenia.Text, textBoxContrasenia2.Text))
                {
                    this.Cuenta.Contraseña = textBoxContrasenia.Text;

                    this.Hide();
                }
                else
                    MessageBox.Show("La contraseña no coincide");
            }
        }

        private bool CamposObligatoriosCompletos()
        {
            if (
            string.IsNullOrEmpty(this.textBoxNombre.Text) &&
            string.IsNullOrEmpty(this.textBoxDireccion.Text) &&
            string.IsNullOrEmpty(this.textBoxContrasenia.Text) &&
            string.IsNullOrEmpty(this.textBoxContrasenia2.Text))
                return false;
            return true;

        }
    }
}


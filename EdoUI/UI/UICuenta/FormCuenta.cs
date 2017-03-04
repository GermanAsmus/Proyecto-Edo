using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Security.Cryptography;

namespace EdoUI.UICuenta
{
    public partial class FormCuenta : Form
    {
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Contrasenia { get; set; } = string.Empty;

        public FormCuenta()
        {
            InitializeComponent();
        }

        private void txbx_NuevaCuenta_Nombre_TextChanged(object sender, EventArgs e)
        {
            this.Nombre = (sender as TextBox).Text;
        }

        private void txbx_NuevaCuenta_Direccion_TextChanged(object sender, EventArgs e)
        {
            this.Direccion = (sender as TextBox).Text;
        }

        private void txbx_NuevaCuenta_Contrasenia_TextChanged(object sender, EventArgs e)
        {
            this.Contrasenia = (sender as TextBox).Text;
        }

        private void btn_NuevaCuenta_Crear_Click(object sender, EventArgs e)
        {
                try
                {
                    MailAddress direccion = new MailAddress(this.Direccion);
                    this.Contrasenia = this.EncriptacionFacil(this.Contrasenia);
                }
                catch
                {

                    MessageBox.Show("El formato de la direccion de correo no es válida. Ej: correo@mail.com");
                    this.DialogResult = DialogResult.Cancel;
                }

        }
        private string EncriptacionFacil(string pContrasenia)
        {
            //encrypt data
            var data = Encoding.Unicode.GetBytes(pContrasenia);
            byte[] encriptado = ProtectedData.Protect(data, null,DataProtectionScope.CurrentUser);

            //return as base64 string
            return Convert.ToBase64String(encriptado);
        }

        public void ModificarCuenta(string pNombre, string pDireccion)
        {
            //valores antiguos.
            this.Nombre = pNombre;
            this.Direccion = pDireccion;
            //campo de la contraseña escondida.
            this.l_NuevaCuenta_Contrasenia.Visible = false;
            this.txbx_NuevaCuenta_Direccion.Visible = false;
        }
    }
}

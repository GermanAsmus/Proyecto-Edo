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

namespace EdoUI.Mensaje
{
    public partial class FormMensaje : Form
    {
        public List<string> Destinatarios { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }

        public FormMensaje()
        {
            InitializeComponent();
            this.Destinatarios = new List<string>();
            this.Asunto = string.Empty;
            this.Mensaje = string.Empty;
        }

        private void tbx_Mensaje_Asunto_TextChanged(object sender, EventArgs e)
        {
            this.Asunto = (sender as TextBox).Text;
        }

        private void rtbx_Mensaje_Contenido_TextChanged(object sender, EventArgs e)
        {
            this.Asunto = (sender as RichTextBox).Text;
        }

        /// <summary>
        /// Elimina un destinatario a la lista de destinatarios, cuando se presiona delete.
        /// </summary>
        private void cbx_Mensaje_Destinatario_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            string aDestinatario = (sender as ComboBox).SelectedText;
            if (string.IsNullOrEmpty(aDestinatario))
                return;

            if (e.KeyData == Keys.Delete)
            {
                this.Destinatarios.Remove(aDestinatario);
                this.cbx_Mensaje_Destinatario.Items.Remove(aDestinatario);
            }
            else if (e.KeyData == Keys.Enter && !this.Destinatarios.Exists(d => string.Equals(d, aDestinatario)))
            {
                try
                {
                  MailAddress direccion = new MailAddress(aDestinatario);
                    this.Destinatarios.Add(aDestinatario);
                    this.cbx_Mensaje_Destinatario.Items.Add(aDestinatario);
                }
                catch
                {
                    MessageBox.Show("La dirección de correo no tiene el formato correcto");
                }
            }
        }

        private void tsb_Mensaje_Enviar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

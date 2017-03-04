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
using EdoUI.DTO;

namespace EdoUI.Mensaje
{
    public partial class FormMensaje : Form
    {
        private List<string> Destinatarios;
        private string Asunto;
        private string Contenido;

        public FormMensaje()
        {
            InitializeComponent();
            this.Destinatarios = new List<string>();
            this.Asunto = string.Empty;
            this.Contenido = string.Empty;
        }

        private void tbx_Mensaje_Asunto_TextChanged(object sender, EventArgs e)
        {
            this.Asunto = (sender as TextBox).Text;
        }

        private void rtbx_Mensaje_Contenido_TextChanged(object sender, EventArgs e)
        {
            this.Contenido = (sender as RichTextBox).Text;
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

        public MensajeDTO Mensaje
        {
            get
            {
                MensajeDTO aMensaje = new MensajeDTO()
                {
                    Asunto = this.Asunto,
                    Contenido = this.Contenido
                };
                this.Destinatarios.ForEach(d => aMensaje.Destinatario.Add(new DireccionCorreoDTO()
                {
                    DireccionDeCorreo = d
                }));
                return aMensaje;
            }
        }

        private void tsb_Mensaje_Enviar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

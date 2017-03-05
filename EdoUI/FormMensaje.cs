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
using Dominio;

namespace EdoUI
{
    public partial class FormMensaje : Form
    {
        private List<string> iDestinatarios;
        private string iAsunto;
        private string iContenido;

        public FormMensaje()
        {
            InitializeComponent();
            this.iDestinatarios = new List<string>();
            this.iAsunto = string.Empty;
            this.iContenido = string.Empty;
        }

        private void tbx_Mensaje_Asunto_TextChanged(object sender, EventArgs e)
        {
            this.iAsunto = (sender as TextBox).Text;
        }

        private void rtbx_Mensaje_Contenido_TextChanged(object sender, EventArgs e)
        {
            this.iContenido = (sender as RichTextBox).Text;
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
                this.iDestinatarios.Remove(aDestinatario);
                this.cbx_Mensaje_Destinatario.Items.Remove(aDestinatario);
            }
            else if (e.KeyData == Keys.Enter && !this.iDestinatarios.Exists(d => string.Equals(d, aDestinatario)))
            {
                try
                {
                    MailAddress direccion = new MailAddress(aDestinatario);
                    this.iDestinatarios.Add(aDestinatario);
                    this.cbx_Mensaje_Destinatario.Items.Add(aDestinatario);
                }
                catch
                {
                    MessageBox.Show("La dirección de correo no tiene el formato correcto");
                }
            }
        }
        public string Asunto { get { return this.iAsunto; } }
        public string Contenido { get { return this.iContenido; } }
        public ICollection<IDireccionCorreo> Destinatario
        {
            get
            {
                List<IDireccionCorreo> aDestinatarios = new List<IDireccionCorreo>();
                this.iDestinatarios.ForEach(d => aDestinatarios.Add(new DireccionCorreo(d)));
                return aDestinatarios;
            }
        }

        private void tsb_Mensaje_Enviar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

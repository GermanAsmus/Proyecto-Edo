using System;
using Dominio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdoUI
{
    public partial class UICuenta : Form
    {
        private ICuentaDeUsuarioDTO iCuenta;
        private IFachadaDominio iFachadaDominio;
        public int iCantidadMensajesPorDescarga = 0;

        public UICuenta(ICuentaDeUsuarioDTO pCuenta, ref IFachadaDominio pFachadaDominio)
        {
            InitializeComponent();
            this.iFachadaDominio = pFachadaDominio;
            this.iCuenta = pCuenta;
            this.InicializarDataGridView();
        }

        private void InicializarDataGridView()
        {
           IEnumerable<IMensajeDTO> aMensajes = this.iFachadaDominio.ObtenerMensajes(this.iCuenta);
           this.MessagesDataGrid.DataSource = aMensajes;
        }
        private void ActualizarDataGridView()
        {
            IEnumerable<IMensajeDTO> aMensajes = this.iFachadaDominio.DescargarMensajes(this.iCuenta, iCantidadMensajesPorDescarga);
            this.MessagesDataGrid.DataSource = aMensajes;
        }

        private void redactarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMensaje aFormMensaje = new FormMensaje();
            DialogResult result = aFormMensaje.ShowDialog(this);
            if (result == DialogResult.OK)
            { 
                bool aResult = this.iFachadaDominio.EnviarMensaje(this.iCuenta, aFormMensaje.Asunto, aFormMensaje.Destinatario, aFormMensaje.Contenido);
                if (aResult)
                {
                    MessageBox.Show("El mensaje fue enviado con éxito");
                }
                else
                {
                    MessageBox.Show("Su mensaje no pudo ser enviado");
                }

            }
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActualizarDataGridView();
        }
    }
}

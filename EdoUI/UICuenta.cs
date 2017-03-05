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
        private ICuentaDeUsuario iCuenta;
        private IFachadaDominio iFachadaDominio;

        public UICuenta(ICuentaDeUsuario pCuenta, ref IFachadaDominio pFachadaDominio)
        {
            InitializeComponent();
            this.iFachadaDominio = pFachadaDominio;
            this.iCuenta = pCuenta;
            this.Actualizar();
        }

        private void InicializarDataGridView()
        {
            ////create datatable and columns,
            //DataTable dtable = new DataTable();
            //dtable.Columns.Add(new DataColumn("Remitente"));
            //dtable.Columns.Add(new DataColumn("Asunto"));

            //mensajesDataGridView.DataSource = dtable;
           
        }
        private void AgregarMensajes(object[] RowValues)
        {
            ////create datatable and columns,
            //DataTable dtable = new DataTable();
            //dtable.Columns.Add(new DataColumn("Remitente"));
            //dtable.Columns.Add(new DataColumn("Asunto"));

            //mensajesDataGridView.DataSource = dtable;

            //DataRow dRow;
            //dRow = dtable.Rows.Add(RowValues);
            //dtable.AcceptChanges();

            //mensajesDataGridView.DataSource = dtable;
        }

        private void Actualizar()
        {
            //IEnumerable<MensajeDTO> aCabeceras = ControladorFachada.DescargarCabeceras(this.iCuenta);
            //if (aCabeceras.Count() > 0)
            //{
            //    foreach (MensajeDTO aMensaje in aCabeceras)
            //    {
            //        AgregarMensajes(new object[] { aMensaje.Remitente.DireccionDeCorreo, aMensaje.Asunto});
            //    }
            //}
                
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
    }
}

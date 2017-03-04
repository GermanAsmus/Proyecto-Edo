using EdoUI.DTO;
using EdoUI.Mensaje;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdoUI.UI.UICuenta
{
    public partial class UICuenta : Form
    {
        private CuentaDTO iCuenta;
        public UICuenta(CuentaDTO pCuenta)
        {
            InitializeComponent();
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

        private void nuevoMensajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMensaje aFormMensaje = new FormMensaje();
            DialogResult result = aFormMensaje.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                MensajeDTO aMensaje = aFormMensaje.Mensaje;
                aMensaje.Remitente = this.iCuenta.DireccionCorreo;
                //ControladorFachada.EnviarNuevoMensaje(aMensaje);
            }
        }
    }
}

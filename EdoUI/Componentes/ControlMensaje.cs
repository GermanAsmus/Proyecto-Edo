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
using ControlDependencia.Dominio;

namespace EdoUI
{
    public partial class ControlMensaje : UserControl
    {
        private IControlador controlador;
        IRepositorio<Mensaje> servicioMensaje;
        public ControlMensaje(ref IControlador pControlador)
        {
            InitializeComponent();
            controlador = pControlador;
            //servicioMensaje = (IRepositorioBase<Completo>)controlador.iGestor.ObtenerServicio(typeof(Completo));
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "¿Está seguro de que quiere cerrar esta ventana?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Parent.Dispose();
        }
    }
}

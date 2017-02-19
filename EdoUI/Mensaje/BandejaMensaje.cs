using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EdoUI.DI;
using Dominio.Entidades.Interfaces;

namespace EdoUI.Mensaje
{
    public partial class BandejaMensaje : UserControl
    {
        public BandejaMensaje()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_BandejaMensaje_NuevoMensaje_Click(object sender, EventArgs e)
        {
            FormMensaje nuevoMensaje = new FormMensaje();
            DialogResult result = nuevoMensaje.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                //send
            }
        }
    }
}

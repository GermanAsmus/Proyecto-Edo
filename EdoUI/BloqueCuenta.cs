using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace EdoUI
{
    public partial class BloqueCuenta : UserControl
    {
        private BandejaMensajes bandeja;
        public BloqueCuenta(Cuenta pCuenta)
        {
            InitializeComponent();
            toolStripLabelNombre.Text = pCuenta.CuentaId;
            bandeja = new BandejaMensajes(new Buzon());

        }

        private void toolStripButtonDesplegar_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EdoUI.Cuenta;

namespace EdoUI
{
    public partial class btn_AbrirCuenta : UserControl
    {
        private FormCuenta iFormCuenta;

        public btn_AbrirCuenta()
        {
            InitializeComponent();
            this.iFormCuenta = new FormCuenta();
        }

        private void btn_Cuenta_Click(object sender, EventArgs e)
        {
            this.iFormCuenta.ShowDialog();
        }
    }
}

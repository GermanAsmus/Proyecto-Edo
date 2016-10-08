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
using Utilidades;
using Utilidades.Misc;
using CapaInterfaces.Modelo;
using CapaInterfaces;

namespace EdoUI
{
    public partial class BandejaCuentas : Bandeja<ICuentaUsuarioDTO>
    {
        public Action ItemSelected;

        private ICollection<ICuentaUsuarioDTO> iCuentas;

        public BandejaCuentas(ICollection<ICuentaUsuarioDTO> pEntidades): base(pEntidades)
        {
            InitializeComponent();
            this.iCuentas = null;
        }

        //private void ListarCuentas(ICollection<ICuentaUsuarioDTO> pCuentas)
        //{
        //    foreach (ICuentaUsuarioDTO cuentaUsuario in pCuentas)
        //    {
        //        this.flowLayoutPanel.Controls.Add(new BloqueCuenta());
        //    }
        //}

        private void BandejaCuentas_Paint(object sender, PaintEventArgs e)
        {
            if (iCuentas == null)
                MessageBox.Show(this, "Al parecer no hay ninguna cuenta en la bandeja, quizas deberías agregar una Nueva Cuenta", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

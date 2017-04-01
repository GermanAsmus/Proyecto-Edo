using Dominio;
using EdoUI.DI;
using System;
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
    public partial class UI : Form
    {
        private IFachadaDominio iFachadaDominio;

        public UI()
        {
            InitializeComponent();
            this.iFachadaDominio = IoCContainer.Resolve<IFachadaDominio>();
            this.UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            IEnumerable<ICuentaDeUsuarioDTO> aAcounts = this.iFachadaDominio.ObtenerCuentas();
            if (aAcounts.Count() > 0)
            {
                CreateNewAccount(this, null);
                AccountsDataGrid.DataSource = aAcounts;
            }

        }

        private void CreateNewAccount(object sender, EventArgs e)
        {
            FormNuevaCuenta aNewAccount = new FormNuevaCuenta();
            DialogResult aResult = aNewAccount.ShowDialog(this);
            if(aResult == DialogResult.OK)
            {
                //this.iFachadaDominio.NuevaCuentaDeUsuario(aNewAccount.Nombre, aNewAccount.Direccion, aNewAccount.Contrasenia);
                this.UpdateDataGrid();
            }
        }

        private void AccountsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ICuentaDeUsuario aSelectedAccount = (ICuentaDeUsuario)(sender as DataGridView).SelectedRows[e.RowIndex].DataBoundItem;
            UICuenta aNewUICuenta = new UICuenta(aSelectedAccount,ref this.iFachadaDominio);
            aNewUICuenta.Show();
        }
    }
}

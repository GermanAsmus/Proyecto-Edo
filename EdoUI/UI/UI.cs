using EdoUI.DTO;
using EdoUI.UICuenta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdoUI.UI
{
    public partial class UI : Form
    {
        //private FachadaDominio iFachadaDominio;

        public UI()
        {
            InitializeComponent();
            //this.iFachadaDominio = new FachadaDominio();
            this.UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            //IEnumerable<ICuentaDeUsuario> aAcounts = this.iFachadaDominio.GetAllAccounts();
            //if (aAcounts.Count() > 0)
            //{
            //    CreateNewAccount(this, null);
            //    AccountsDataGrid.DataSource = aAcounts;
            //}

        }

        private void CreateNewAccount(object sender, EventArgs e)
        {
            FormCuenta aNewAccount = new FormCuenta();
            aNewAccount.ShowDialog(this);
            this.UpdateDataGrid();
        }

        private void AccountsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ICuentaDeUsuario aSelectedAccount = (ICuentaDeUsuario)(sender as DataGridView).SelectedRows[e.RowIndex].DataBoundItem;
            //CuentaDTO aCuentaDTO = CuentaDTO.ParseFromCuenta(aSelectedAccount);
            //UICuenta.UICuenta aNewUICuenta = new UICuenta.UICuenta(aCuentaDTO);
        }
    }
}

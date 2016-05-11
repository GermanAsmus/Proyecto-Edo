using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdoUI
{
    public partial class ControlAdjuntos : UserControl
    {
        public IList<string> AdjuntosPath;
        public ControlAdjuntos()
        {
            InitializeComponent();
            AdjuntosPath = new List<string>();
        }

        private void toolStripButtonImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            DialogResult result = fd.ShowDialog();
            if(result == DialogResult.OK)
            {
                this.AdjuntosPath.Add(fd.FileName);
                this.checkedListBoxAdjuntos.Items.Add(fd.FileName);
            }
        }

        private void checkedListBoxAdjuntos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}

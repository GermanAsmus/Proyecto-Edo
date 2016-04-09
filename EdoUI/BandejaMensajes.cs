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
    public partial class BandejaMensajes : UserControl
    {
        public Action ItemSelected;

        private Buzon unBuzon;

        public ControlCollection Bandeja { get; set; }

        private void UpdateSize()
        {
            todosToolStripMenuItem.Height = (flowLayoutPanelMensajes.Controls.Count) * (flowLayoutPanelMensajes.Controls[0].Size.Height);
            this.Size = new Size(this.Size.Width, todosToolStripMenuItem.Size.Height);
            this.Refresh();
        }

        public BandejaMensajes(Buzon pBuzon)
        {
            InitializeComponent();
            Bandeja = new ControlCollection(this);
            unBuzon = pBuzon;
            unBuzon.BagChanged += BagHasChanged;
        }

        private void BagHasChanged()
        {
                Bandeja.Add(new BloqueMensaje(unBuzon.Cabeceras.Last()));
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bandeja = this.flowLayoutPanelMensajes.Controls;
            ItemSelected();
        }

        private void leidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //discriminar por estado "Leido"
            Bandeja = this.flowLayoutPanelMensajes.Controls;
            ItemSelected();
        }

        private void noLeidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //discriminar por estado "No Leido"
            Bandeja = this.flowLayoutPanelMensajes.Controls;
            ItemSelected();
        }

        private void toolStripButtonDesplegar_Click(object sender, EventArgs e)
        {
            if (this.Size != this.toolStripCabecera.Size)
                this.Size = this.toolStripCabecera.Size;
            else
                this.UpdateSize();
        }
    }
}

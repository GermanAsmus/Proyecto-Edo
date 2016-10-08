using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;
using System.Threading;
using System.Timers;
using Utilidades.Internet;

namespace EdoUI
{
    public partial class Bloque<T> : UserControl where T : class
    {
        public Bloque(string[] pArgumentos, Button[] pBotones)
        {
            InitializeComponent();

            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.RowCount = 1;

            foreach (string argumento in pArgumentos)
            {
                this.AgregarColumna(new Label() { Text = argumento });
            }

            foreach (Button boton in pBotones)
            {
                this.AgregarColumna(boton);
            }
        }

        private void AgregarColumna(Control pControl)
        {
            this.tableLayoutPanel1.ColumnCount++;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(pControl);
        }

    }
}

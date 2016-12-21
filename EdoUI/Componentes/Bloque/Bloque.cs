﻿using System;
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
        T iEntidad;
        public Bloque(ICollection<Control> pControles, T pEntidad)
        {
            InitializeComponent();

            if (pEntidad == null)
                MessageBox.Show("Las acciones no pueden ser dirigidas a ninguna entidad");

            if (pControles == null)
                MessageBox.Show("Los controles de informacion no pueden estar vacios");

            this.iEntidad = pEntidad;

            foreach (Control control in pControles)
            {
                this.AgregarColumna(control);
            }
        }

        private void NuevoMensaje_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AgregarColumna(Control pControl)
        {
            this.bloqueTablePanel.Controls.Add(pControl);
        }

    }
}

﻿using System;
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

namespace EdoUI.Cuenta
{
    public partial class BandejaCuenta : UserControl
    {

        /// <summary>
        /// Componentes:
        /// Información de la cuenta *
        /// Modificación de la cuenta *
        /// Bandeja de mensajes de la cuenta *
        /// Crear mensaje *
        /// </summary>

        public BandejaCuenta()
        {
            InitializeComponent();
        }

        public void BandejaMensajes(ICuenta pCuenta)
        {

        }

        public void FormCuenta(ICuenta pCuenta, bool pEditable = false)
        {
            //FormCuenta control = IoCContainer.Resolve<FormCuenta>();
            //set all the properties
            //control.Cuenta = pCuenta;
            //control.isEditable = pEditable;
            //insert the control into a container on the form

            //control.ShowDialog();
        }

        private void btn_NuevaCuenta_Click(object sender, EventArgs e)
        {
            FormCuenta form = new FormCuenta();
            DialogResult r = form.ShowDialog();
            if (r == DialogResult.OK)
            {
                //add the account
            }
            else
            {
                this.Focus();
            }
        }
    }
}

﻿using System;
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
    public partial class BloqueMensaje : UserControl
    {
        public Mensaje Mensaje { get; }

        public string Estado
        {
            get { return this.toolStripStatusLabel.Text; }
            set { this.toolStripStatusLabel.Text = value; }
        }
        public string Remitente
        {
            get { return this.labelRemitente.Text; }
            //set { this.labelRemitente.Text = value; }
        }
        public string Asunto
        {
            get { return this.labelAsunto.Text; }
            //set { this.labelAsunto.Text = value; }
        }

        public BloqueMensaje(Mensaje pMensaje)
        {
            InitializeComponent();
            Mensaje = pMensaje;
            this.labelAsunto.Text = Mensaje.Asunto;
            //this.labelRemitente.Text = Mensaje.Remitente;
            this.Estado = "Descargando";
        }
    }
}
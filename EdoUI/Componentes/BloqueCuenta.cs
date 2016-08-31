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
//using ControlDependencia;
//using ControlDependencia.Dominio;

namespace EdoUI
{
    public partial class BloqueCuenta : UserControl
    {
        //private IControlador controlador;
        private BandejaMensajes bandeja;
        //public BloqueCuenta(CuentaDAO pCuenta, ref IControlador pControlador)
        //{
        //    InitializeComponent();
        //    this.controlador = pControlador;
        //    //bandeja = new BandejaMensajes(new Buzon());
        //}

        private void toolStripButtonDesplegar_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void toolStripButtonRedactar_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage("Nuevo Mensaje");
            //tab.Controls.Add(new ControlMensaje(ref controlador) { Dock = DockStyle.Fill });
            tabControlMensajes.TabPages.Add(tab);
        }
    }
}

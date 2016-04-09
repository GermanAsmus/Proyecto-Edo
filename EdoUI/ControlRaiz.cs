using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlDependencia;
//using ContenedorRaiz;
using Modelo;

namespace EdoUI
{
    public partial class ControlRaiz : UserControl
    {
        private TabControl contenedor;
        private IControlador controlador;

        IServicio<Cuenta> cuentas;

        public ControlRaiz()
        {
            InitializeComponent();
            contenedor = new TabControl() { Dock = DockStyle.Fill };

            controlador = IoCContenedor.Resolver<IControlador>();
            
            cuentas = (IServicio<Cuenta>)controlador.iGestor.ObtenerServicio(typeof(Cuenta));
            cuentas.ObtenerTodos().ToList().ForEach(x => AgregarControl(new BloqueCuenta(x)));
            
        }
        private void toolStripButtonNuevaCuenta_Click(object sender, EventArgs e)
        {
            var sevicioServidor = (IServicio<Servidor>)controlador.iGestor.ObtenerServicio(typeof(Servidor));
            Control nuevaCuenta = new ControlCuenta(cuentas) { Name = "Nueva Cuenta", Dock = DockStyle.Fill };

            nuevaCuenta.Disposed += NuevoControl_Disposed;
            AgregarControl(nuevaCuenta);
        }
        private void NuevoControl_Disposed(object sender, EventArgs e)
        {
            foreach (TabPage item in contenedor.TabPages)
            {
                if (!item.HasChildren)
                    contenedor.TabPages.Remove(item);
                if (contenedor.TabPages.Count > 0)
                    contenedor.SelectTab(contenedor.TabCount - 1);
            }
        }
        private void AgregarControl(Control pControl)
        {
            TabPage tab = new TabPage(pControl.Name);
            tab.Controls.Add(pControl);
            contenedor.TabPages.Add(tab);
            tableLayoutPanelControlCuentas.Controls.Add(contenedor);
            contenedor.SelectTab(contenedor.TabCount - 1);
        }
        private void toolStripButtonRedactar_Click(object sender, EventArgs e)
        {

            IServicio<Completo> servicioMensaje = (IServicio<Completo>)controlador.iGestor.ObtenerServicio(typeof(Completo));
            Control nuevoMensaje = new ControlMensaje(servicioMensaje) { Name = "Nuevo Mensaje", Dock = DockStyle.Fill };
            nuevoMensaje.Disposed += NuevoControl_Disposed;
            AgregarControl(nuevoMensaje);
        }
    }
}

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
using Modelo;
using Dominio;

namespace EdoUI
{
    public partial class ControlCuenta : UserControl
    {
        public Cuenta nuevaCuenta { get; }
        private IControlador controlador;
        private IEnumerable<Servidor> servidores;
        //private IServicio<Cuenta> servicioCuenta;

        public ControlCuenta(IEnumerable<Servidor> pServidores, ref IControlador pControlador)//IServicio<Cuenta> servicio)
        {
            InitializeComponent();
            nuevaCuenta = new Cuenta();
            controlador = pControlador;
            servidores = pServidores;
            //servicioCuenta = servicio;

            //IServicio<Servidor> servicioServidores = (IServicio<Servidor>)servicioCuenta.GestorServicio.ObtenerServicio(typeof(Servidor));

            // var iServidores = servicioServidores.ObtenerTodos().ContinueWith((y) => { return y.Result.Select(x => x.Nombre).ToArray(); });
            //Task.WaitAll(iServidores);

            comboBoxServidores.Items.AddRange(servidores.Select(x => x.Nombre).ToArray());//iServidores.Result);
        }
        //private async Task<string[]> ObtenerServidores()
        //{
        //    IServicio<Servidor> servicioServidores = (IServicio<Servidor>)servicioCuenta.GestorServicio.ObtenerServicio(typeof(Servidor));
        //    return await servicioServidores.ObtenerTodos().ContinueWith((y) => { return y.Result.Select(x => x.Nombre).ToArray(); });
        //}
        //private async void toolStripButtonAceptar_Click(object sender, EventArgs e)
        //{
        //    if (comboBoxServidores.SelectedItem == null)
        //        MessageBox.Show("No ha seleccionado el servidor");
        //    else
        //    {
        //        nuevaCuenta.ServidorId = comboBoxServidores.SelectedItem.ToString();
        //        var servicioCuenta = (RepositorioCuenta)controlador.iGestor.ObtenerServicio(typeof(Cuenta));
        //        await servicioCuenta.Agregar(nuevaCuenta, servidores.First(x => x.Nombre == nuevaCuenta.ServidorId));
        //        Parent.Dispose();
        //    }
        //}

        //private void textBoxNombre_TextChanged(object sender, EventArgs e)
        //{
        //    nuevaCuenta.CuentaId = textBoxNombre.Text;
        //}

        //private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        //{
        //    nuevaCuenta.DireccionId = textBoxDireccion.Text;
        //}

        //private void textBoxContrasenia2_TextChanged(object sender, EventArgs e)
        //{
        //    if (string.Compare(textBoxContrasenia.Text, textBoxContrasenia2.Text) > 0)
        //        textBoxContrasenia.ForeColor = Color.Red;
        //    else
        //    {
        //        textBoxContrasenia.ForeColor = Color.Green;
        //        nuevaCuenta.Contraseña = textBoxContrasenia.Text;
        //    }
        //}
    }
}

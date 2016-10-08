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
using Utilidades;
using Utilidades.Misc;
using CapaInterfaces;

namespace EdoUI
{
    public abstract partial class Bandeja<T> : UserControl where T : class
    {
        protected ICollection<T> iEntidades;
        protected ControlCollection iBandejaElementos { get; set; }

        public Bandeja(ICollection<T> pEntidades)
        {
            InitializeComponent();

            this.iEntidades = pEntidades;

            iBandejaElementos = new ControlCollection(this);

            this.ActualizarBandaja();
        }

        public void ActualizarBandaja()
        {
            this.iEntidades.ToList().ForEach(entidad => this.iBandejaElementos.Add( new Bloque<T>(new string[]{ },new Button[]{ })));
        }
    }
}

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

namespace EdoUI
{
    public partial class ControlMensaje : UserControl
    {
        IServicio<Completo> servicioMensaje;
        public ControlMensaje(IServicio<Completo> servicio)
        {
            InitializeComponent();
            servicioMensaje = servicio;
        }
    }
}

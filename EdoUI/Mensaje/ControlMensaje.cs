using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdoUI.Mensaje
{
    public partial class ControlMensaje : UserControl
    {
        public string[] Destinatarios { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }
        public string[] Adjuntos { get; set; }

        public ControlMensaje()
        {
            InitializeComponent();
        }
    }
}

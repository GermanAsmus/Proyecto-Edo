using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EdoUI
{
    public partial class Bandeja<T> : UserControl where T : class
    {
        public Bandeja()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Crea un nuevo bloque para la bandeja.
        /// </summary>
        /// <param name="pDatos">todos los datos propios del bloque</param>
        /// <param name="pAcciones">todas las acciones (botones) del bloque</param>
        /// <returns></returns>
        public void NuevoBloque(string[] pDatos, T pEntidad)
        {
            ICollection<Control> controles = new List<Control>();
            pDatos.ToList().ForEach(dato => controles.Add(new Label() { Text = dato, Dock = DockStyle.Fill }));

            this.BandejaTablePanel.Controls.Add(new Bloque<T>(controles, pEntidad) { Dock = DockStyle.Fill });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public abstract class MensajeSinVisibilidadDefinida : IStateVisibilidad
    {
        public IRegistroMensaje RegistroMensaje { get; set; }

        public abstract EstadoVisibilidad ObtenerEstadoVisibilidad();

        public MensajeSinVisibilidadDefinida()
        {
            this.RegistroMensaje = new RegistroMensaje();
        }
    }
}

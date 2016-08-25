using System;
using System.Collections.Generic;

namespace Modelo
{
    public class MensajeNoVisto : IStateVisibilidad
    {
        public IRegistroMensaje RegistroMensaje { get; set; }

        public EstadoVisibilidad ObtenerEstadoVisibilidad()
        {
            return EstadoVisibilidad.No_Visto;
        }

        public MensajeNoVisto()
        {
            this.RegistroMensaje = new RegistroMensaje();
        }
    }
}

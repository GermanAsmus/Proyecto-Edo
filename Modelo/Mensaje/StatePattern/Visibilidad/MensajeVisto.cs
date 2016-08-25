using System;

namespace Modelo
{
    public class MensajeVisto : IStateVisibilidad
    {
        public IRegistroMensaje RegistroMensaje { get; set; }

        public EstadoVisibilidad ObtenerEstadoVisibilidad()
        {
            return EstadoVisibilidad.Visto;
        }
        public MensajeVisto()
        {
            this.RegistroMensaje = new RegistroMensaje();
        }
    }
}

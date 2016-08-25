using System;

namespace Modelo
{
    public class MensajeVisto : MensajeSinVisibilidadDefinida
    {
        public override EstadoVisibilidad ObtenerEstadoVisibilidad()
        {
            return EstadoVisibilidad.Visto;
        }
        public MensajeVisto() : base() { }
    }
}

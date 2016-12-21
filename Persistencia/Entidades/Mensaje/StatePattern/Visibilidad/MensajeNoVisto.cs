using System;
using System.Collections.Generic;

namespace Modelo
{
    public class MensajeNoVisto : MensajeSinVisibilidadDefinida
    {
        public override EstadoVisibilidad ObtenerEstadoVisibilidad()
        {
            return EstadoVisibilidad.No_Visto;
        }

        public MensajeNoVisto() : base() { }
    }
}

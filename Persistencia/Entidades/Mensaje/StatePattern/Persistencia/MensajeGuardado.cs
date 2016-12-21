using System;
using System.Linq;
using System.Collections.Generic;

namespace Modelo
{
    public class MensajeGuardado : MensajeSinEstadoDePersistenciaDefinido
    {
        public new ICollection<IRegistroMensaje> RegistroMensajes { get; private set; }

        public override EstadoPersistencia ObtenerEstadoPersistencia()
        {
            return EstadoPersistencia.Guardado;
        }

        public MensajeGuardado() : base() { }
    }
}

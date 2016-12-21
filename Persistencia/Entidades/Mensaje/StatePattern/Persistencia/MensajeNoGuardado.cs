using System;
using System.Collections.Generic;

namespace Modelo
{
    public class MensajeNoGuardado : MensajeSinEstadoDePersistenciaDefinido
    {
        public new ICollection<IRegistroMensaje> RegistroMensajes { get; private set; }

        public override EstadoPersistencia ObtenerEstadoPersistencia()
        {
            return EstadoPersistencia.No_Guardado;
        }

        public MensajeNoGuardado() : base() { }
    }
}

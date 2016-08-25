using System;

namespace Modelo
{
    public class MensajeGuardado : IStatePersistencia
    {
        public IRegistroMensaje RegistroMensaje { get; set; }

        public EstadoPersistencia ObtenerEstadoPersistencia()
        {
            return EstadoPersistencia.Guardado;
        }

        public MensajeGuardado()
        {
            this.RegistroMensaje = new RegistroMensaje();
        }
    }
}

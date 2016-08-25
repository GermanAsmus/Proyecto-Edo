using System;

namespace Modelo
{
    public class MensajeEnviado : IStateComunicacion
    {
        public IRegistroMensaje RegistroMensaje { get; set; }
        public EstadoComunicacion ObtenerEstadoComunicacion()
        {
            return EstadoComunicacion.Enviado;
        }

        public MensajeEnviado()
        {
            this.RegistroMensaje = new RegistroMensaje();
        }



    }
}

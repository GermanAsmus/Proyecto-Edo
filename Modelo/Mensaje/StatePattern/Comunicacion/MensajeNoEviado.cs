using System;

namespace Modelo
{
    public class MensajeNoEviado : IStateComunicacion
    {
        public IRegistroMensaje RegistroMensaje { get; set; }

        public EstadoComunicacion ObtenerEstadoComunicacion()
        {
            return EstadoComunicacion.No_Enviado;
        }
    }
}

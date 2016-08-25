using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public class MensajeEnviado : MensajeSinEstadoDeComunicacionDefinido
    {
        public new ICollection<IRegistroMensaje> RegistroMensajes { get; private set; }
        public override EstadoComunicacion ObtenerEstadoComunicacion()
        {
            return EstadoComunicacion.Enviado;
        }

        public MensajeEnviado()
        {
            this.RegistroMensajes = new List<IRegistroMensaje>();
        }



    }
}

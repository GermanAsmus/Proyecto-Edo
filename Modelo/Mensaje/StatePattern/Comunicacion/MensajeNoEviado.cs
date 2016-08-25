using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public class MensajeNoEviado : MensajeSinEstadoDeComunicacionDefinido
    {
        public new ICollection<IRegistroMensaje> RegistroMensajes { get; private set; }

        public override EstadoComunicacion ObtenerEstadoComunicacion()
        {
            return EstadoComunicacion.No_Enviado;
        }
        public MensajeNoEviado()
        {
            this.RegistroMensajes = new List<IRegistroMensaje>();
        }
    }
}

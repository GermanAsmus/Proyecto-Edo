using System;
using System.Collections.Generic;
namespace Modelo
{
    public class MensajeUsuarioDTO : MensajeCompletoDTO
    {
        public KeyValuePair<DateTime,EstadoComunicacion> EstadoComunicacion { get; set; }
    }
}

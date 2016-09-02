using System;
using System.Collections.Generic;
namespace Modelo
{
    public class MensajeExternoIncompletoDTO : MensajeIncompletoDTO, IMensajeExternoDTO
    {
        public KeyValuePair<DateTime,EstadoVisibilidad> EstadoVisibilidad { get; set; }
    }
}

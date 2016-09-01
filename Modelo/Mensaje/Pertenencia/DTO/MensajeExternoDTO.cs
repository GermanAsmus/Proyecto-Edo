using System;
using System.Collections.Generic;
namespace Modelo
{
    public class MensajeExternoDTO : MensajeCompletoDTO
    {
        public KeyValuePair<DateTime,EstadoVisibilidad> EstadoVisibilidad { get; set; }
    }
}

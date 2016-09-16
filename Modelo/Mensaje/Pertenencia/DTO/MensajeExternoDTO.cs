using System;
using System.Collections.Generic;
namespace Modelo
{
    public class IMensajeExternoDTO: MensajeDTO
    {
        public KeyValuePair<DateTime,EstadoVisibilidad> EstadoVisibilidad { get; set; }
    }
}

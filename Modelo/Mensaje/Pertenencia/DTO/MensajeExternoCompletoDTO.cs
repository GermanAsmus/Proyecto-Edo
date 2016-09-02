using System;
using System.Collections.Generic;
namespace Modelo
{
    public class MensajeExternoCompletoDTO : MensajeCompletoDTO, IMensajeExternoDTO
    {
        public KeyValuePair<DateTime,EstadoVisibilidad> EstadoVisibilidad { get; set; }
    }
}

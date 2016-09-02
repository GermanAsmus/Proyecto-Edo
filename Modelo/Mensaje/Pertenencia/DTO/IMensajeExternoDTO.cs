using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
namespace Modelo
{
    public interface IMensajeExternoDTO: IMensajeDTO
    {
        KeyValuePair<DateTime,EstadoVisibilidad> EstadoVisibilidad { get; set; }
    }
}

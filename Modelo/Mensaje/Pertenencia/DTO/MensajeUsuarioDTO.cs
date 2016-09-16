using CapaInterfaces.Modelo;
using Modelo;
using System;
using System.Collections.Generic;
namespace Modelo
{
    public class MensajeUsuarioDTO : MensajeDTO
    {
        public KeyValuePair<DateTime,IEstado> EstadoComunicacion { get; set; }
    }
}

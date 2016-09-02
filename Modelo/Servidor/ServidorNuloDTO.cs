using System;
using System.Collections.Generic;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class ServidorNuloDTO : IServidorDTO
    {
        public string Nombre { get; set; }

        public ICollection<IProtocoloDTO> Protocolos { get; set; }
        public ServidorNuloDTO()
        {
            this.Nombre = string.Empty;

        }
    }
}
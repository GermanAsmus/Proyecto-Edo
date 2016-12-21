using EdoUI.DTO;
using System;
using System.Collections.Generic;

namespace Persistencia
{
    public class ServidorDTO : IServidorDTO
    {
        //Tipo del servidor.
        public string Nombre { get; set; }

        //Protocolos de comunicacion del servidor
        public ICollection<IProtocoloDTO> Protocolos { get; set; }

        public ServidorDTO()
        {
            this.Protocolos = new List<IProtocoloDTO>();
        }
    }
}

using CapaInterfaces.Modelo;
using System.Collections.Generic;
using System;

namespace Modelo
{
    public class ServidorFactory : Factory<ICollection<IProtocoloDTO>>
    {
        public override ICollection<IProtocoloDTO> AgregarEntidad()
        {
            IList<IProtocoloDTO> protocolos = new List<IProtocoloDTO>()
            {
                
            };
            return protocolos;
        }
    }
}
using System;
using System.Collections.Generic;
using CapaInterfaces.Modelo;

namespace Modelo
{
    internal class ServidorYahooFactory : IServidorFactory
    {
        public ICollection<IProtocoloDTO> AgregarProtocolo()
        {
            IList<IProtocoloDTO> protocolos = new List<IProtocoloDTO>()
            {
                new ProtocoloSMTP(),
                new ProtocoloPOP()
            };
            return protocolos;
        }
    }
}
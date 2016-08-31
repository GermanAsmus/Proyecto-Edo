using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public class ServidorGmailFactory : IServidorFactory
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
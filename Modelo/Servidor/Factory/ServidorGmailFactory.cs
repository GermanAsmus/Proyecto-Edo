using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public class ServidorGmailFactory : IServidorFactory
    {
        public ICollection<IProtocolo> AgregarProtocolo()
        {
            IList<IProtocolo> protocolos = new List<IProtocolo>()
            {
                new ProtocoloSMTP(),
                new ProtocoloPOP()
            };
            return protocolos;
        }
    }
}
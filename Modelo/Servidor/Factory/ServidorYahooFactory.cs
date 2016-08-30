using System;
using System.Collections.Generic;
using CapaInterfaces.Modelo;

namespace Modelo
{
    internal class ServidorYahooFactory : IServidorFactory
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
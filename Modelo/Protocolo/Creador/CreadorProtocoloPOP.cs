using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CreadorProtocoloPOP : CreadorProtocolo
    {
        protected override IProtocolo CrearProtocolo()
        {
            return new ProtocoloPOP();
        }
    }
}
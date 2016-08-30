using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CreadorProtocoloSMTP : CreadorProtocolo
    {
        protected override IProtocolo CrearProtocolo()
        {
            return new ProtocoloSMTP();
        }
    }
}
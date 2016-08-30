using CapaInterfaces.Modelo;

namespace Modelo
{
    public class ProtocoloSMTP : Protocolo
    {
        public ProtocoloSMTP() : base()
        {
            this.Nombre = "smtp";
        }
    }
}

using CapaInterfaces.Modelo;

namespace Modelo
{
    public class ProtocoloSMTP : ProtocoloDTO
    {
        public ProtocoloSMTP() : base()
        {
            this.Nombre = "smtp";
        }
    }
}

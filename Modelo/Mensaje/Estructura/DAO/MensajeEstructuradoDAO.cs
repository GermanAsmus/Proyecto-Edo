
using CapaInterfaces.Modelo;

namespace Modelo
{
    public abstract class MensajeEstructuradoDAO : MensajeDAO
    {
        public MensajeEstructuradoDAO(MensajeFactory pMensajeFactory) : base(pMensajeFactory)
        {
        }

    }
}

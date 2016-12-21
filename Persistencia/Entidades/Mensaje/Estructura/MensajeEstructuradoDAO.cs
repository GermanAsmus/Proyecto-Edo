
using CapaInterfaces.Modelo;

namespace Modelo
{
    public abstract class MensajeEstructuradoDAO : MensajeDAO, IMensajeEstructurado
    {
        public MensajeEstructuradoDAO(MensajeFactory pMensajeFactory) : base(pMensajeFactory)
        {
        }
    }
}

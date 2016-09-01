
namespace Modelo
{
    public abstract class MensajeEstructuradoDAO : MensajeDAO
    {
        protected IMensajeEstructuradoDTO iMensajeEstructuradoDTO;
        public MensajeEstructuradoDAO(IMensajeFactory pMensajeFactory) : base(pMensajeFactory)
        {
        }
    }
}

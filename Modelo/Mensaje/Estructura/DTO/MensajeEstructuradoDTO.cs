
namespace Modelo
{
    public abstract class MensajeEstructuradoDTO : MensajeDTO, IMensajeEstructuradoDTO
    {
        public EstructuraMensaje Estructura { get; protected set; }
     }
}

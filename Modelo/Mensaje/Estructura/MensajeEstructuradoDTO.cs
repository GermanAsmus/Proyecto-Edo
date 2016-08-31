
namespace Modelo
{
    public abstract class MensajeEstructuradoDTO : MensajeDTO, IMensajeEstructurado
    {
        public abstract EstructuraMensaje Estructura { get; }
     }
}

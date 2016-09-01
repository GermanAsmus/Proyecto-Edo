using CapaInterfaces.Modelo;

namespace Modelo
{
    public interface IMensajeEstructuradoDTO : IMensajeDTO
    {
        EstructuraMensaje Estructura { get; }
    }
}

using Modelo;

namespace ControlDependencia
{
    public interface IProtocolo
    {
        void Descargar(int pCantidad,IProtocoloRecepcion pProtocoloRecepcion);
        void Eliminar(int pId,IProtocoloRecepcion pProtocoloRecepcion);
        void Enviar(Mensaje pMensaje, IProtocoloTransmision pProtocoloRecepcion);
    }
}

using Modelo;

namespace ControlDependencia.Servicio
{
    /// <summary>
    /// Protocolo que se implementa para manejar los servicios de internet, de recepción y transmisión de mensajes
    /// </summary>
    public interface IProtocolo
    {
        /// <summary>
        /// Descarga una cantidad de mensajes de una cuenta mediante un protocolo de recepción.
        /// </summary>
        /// <param name="pCantidad">Cantidad de mensjes a descargar</param>
        /// <param name="pProtocoloRecepcion">Protocolo de recepción de correos</param>
        void Descargar(int pCantidad,IProtocoloRecepcion pProtocoloRecepcion);
        /// <summary>
        /// Elimina un mensaje de una cuenta mediante un protocolo de recepción
        /// </summary>
        /// <param name="pId">Identificador del mensaje</param>
        /// <param name="pProtocoloRecepcion">Protocolo de recepción de correos</param>
        void Eliminar(int pId,IProtocoloRecepcion pProtocoloRecepcion);
        /// <summary>
        /// Envía un menaje mediante un protocolo de transmisión.
        /// </summary>
        /// <param name="pMensaje">Mensaje a enviar</param>
        /// <param name="pCuenta">Cuenta del usuario</param>
        /// <param name="pProtocoloTansmision">Protocolo de transmisión de correos</param>
        void Enviar(Mensaje pMensaje, Cuenta pCuenta, IProtocoloTransmision pProtocoloTansmision);
    }
}

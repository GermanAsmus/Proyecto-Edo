using ControlDependencia.Utilidades;
using Modelo;

namespace ControlDependencia.Servicio
{
    /// <summary>
    /// Fachada del paquete de servicio
    /// </summary>
    public interface IServicio
    {
        /// <summary>
        /// Propiedad que define los protocolos de recepción y transmisión que se utilizarán en los mensajes.
        /// </summary>
        IProtocolo iProtocolo { get; set; }
        /// <summary>
        /// Envía un menaje mediante un protocolo de transmisión.
        /// </summary>
        /// <param name="pMensaje">Mensaje a enviar</param>
        /// <param name="pCuenta">Cuenta del usuario</param>
        /// <param name="pProtocoloTansmision">Protocolo de transmisión de correos</param>
        void Enviar(Mensaje pMensaje, Cuenta pCuenta, IProtocoloTransmision pProtocoloTransmision);
        /// <summary>
        /// Descarga una cantidad de mensajes de una cuenta mediante un protocolo de recepción.
        /// </summary>
        /// <param name="pCantidad">Cantidad de mensjes a descargar</param>
        /// <param name="pCuenta">Cuenta del usuario</param>
        /// <param name="pProtocoloRecepcion">Protocolo de recepción de correos</param>
        void Descargar(int pCantidad, Cuenta pCuenta, IProtocoloRecepcion pProtocoloRecepcion, IBuzon pBuzon);
        /// <summary>
        /// Elimina un mensaje de una cuenta mediante un protocolo de recepción
        /// </summary>
        /// <param name="pId">Identificador del mensaje</param>
        /// <param name="pCuenta">Cuenta del usuario</param>
        /// <param name="pProtocoloRecepcion">Protocolo de recepción de correos</param>
        void Eliminar(int pUid, Cuenta pCuenta, IProtocoloRecepcion pProtocoloRecepcion);
    }
}

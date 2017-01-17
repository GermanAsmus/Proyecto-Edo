using Dominio.Entidades.Interfaces;
using System.Threading;

namespace Dominio.ServicioCorreo
{
    /// <summary>
    /// Protocolo que se implementa para manejar los servicios de internet, de recepción y transmisión de mensajes
    /// </summary>
    public interface IProtocolo
    {
        void Descargar(int pIdMensaje, CancellationToken pCancellation, IProtocoloRecepcion pProtocoloRecepcion);
        void Descargar(CancellationToken pCancellation, IProtocoloRecepcion pProtocoloRecepcion);
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
        void Enviar(IMensaje pMensaje, ICuenta pCuenta, IProtocoloTransmision pProtocoloTansmision);
    }
}

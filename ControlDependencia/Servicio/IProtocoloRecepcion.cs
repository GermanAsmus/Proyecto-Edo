using ControlDependencia.Utilidades;
using Modelo;
using System.Threading;

namespace ControlDependencia.Servicio
{
    /// <summary>
    /// Protocolo de recepción de correos.
    /// </summary>
    public interface IProtocoloRecepcion
    {
        /// <summary>
        /// Cuenta del usuario que utiliza el protocolo.
        /// </summary>
        Cuenta CuentaUsuario { get; set; }
        /// <summary>
        /// Entidad que mantiene los mensajes descargados.
        /// </summary>
        IBuzon Buzon { get; set; }
        /// <summary>
        /// Descarga las cabeceras de los mensajes del servidor.
        /// </summary>
        void Descargar(CancellationToken pCancellation);
        /// <summary>
        /// Descarga un mensaje particular del servidor.
        /// </summary>
        void Descargar(int pIdMensaje, CancellationToken pCanselation);
        /// <summary>
        /// Elimina una cantidad de mensajes del servidor.
        /// </summary>
        /// <param name="pId">Identificador del mensaje en el servidor</param>
        void Eliminar(int pId);
    }
}

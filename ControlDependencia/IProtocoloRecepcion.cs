using Modelo;

namespace ControlDependencia
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
        /// Descarga una cantiad de mensajes del servidor.
        /// </summary>
        /// <param name="pCantidad">Cantidad de mensajes a descargar</param>
        void Descargar(int pCantidad);
        /// <summary>
        /// Elimina una cantidad de mensajes del servidor.
        /// </summary>
        /// <param name="pId">Identificador del mensaje en el servidor</param>
        void Eliminar(int pId);
    }
}

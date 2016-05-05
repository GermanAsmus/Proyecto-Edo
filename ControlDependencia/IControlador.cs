using Modelo;
using System.Collections.Generic;

namespace ControlDependencia
{
    /// <summary>
    /// Interfaz de la Fachada del Dominio.
    /// Todas las funcionalidades del programa se detallan en esta interfaz.
    /// </summary>
    public interface IControlador
    {
        /// <summary>
        /// Agrega una cuenta nueva al sistema.
        /// </summary>
        /// <param name="pCuenta">Nueva cuenta que se agregará al sistema</param>
        /// <param name="pServidor">Servidor de correo que utiliza la nueva cuenta</param>
        /// <returns>0 si no se pudo completar la operación, sino la operación fue exitosa</returns>
        int AregarCuenta(Cuenta pCuenta, Servidor pServidor);
        /// <summary>
        /// Confirma la edición de una cuenta ya existente en el sistema.
        /// </summary>
        /// <param name="pCuenta">Cuenta editada</param>
        /// <returns>0 si no se pudo completar la operación, sino la operación fue exitosa</returns>
        int EditarCuenta(Cuenta pCuenta);
        /// <summary>
        /// Confirma la edición de una dirección de correo ya existente en el sistema.
        /// </summary>
        /// <param name="pDireccionCorreo">Dirección de correo editada</param>
        /// <returns>0 si no se pudo completar la operación, sino la operación fue exitosa</returns>
        int EditarDireccionDeCorreo(DireccionCorreo pDireccionCorreo);
        /// <summary>
        /// Elimina una dirección de correo existente en el sistema.
        /// </summary>
        /// <param name="pId">Identificador único de la dirección de correo</param>
        /// <returns>0 si no se pudo completar la operación, sino la operación fue exitosa</returns>
        int EliminarDireccionDeCorreo(int pId);
        /// <summary>
        /// Elimina una dirección de correo existente en el sistema.
        /// </summary>
        /// <param name="pDireccionDeCorreo">Dirección de correo real de la dirección de correo, ej: miCorreo@correo.com</param>
        /// <returns>0 si no se pudo completar la operación, sino la operación fue exitosa</returns>
        int EliminarDireccionDeCorreo(string pDireccionDeCorreo);
        /// <summary>
        /// Obtiene una dirección de correo existente en el sistema.
        /// </summary>
        /// <param name="pId">Identificador único de la dirección de correo</param>
        /// <returns>La dirección de correo correspondiente al identificador</returns>
        DireccionCorreo ObtenerDireccionDeCorreo(int pId);
        /// <summary>
        /// Obtiene una direccion de correo existente en el sistema.
        /// </summary>
        /// <param name="pDireccionDeCorreo">Dirección de correo real de la dirección de correo, ej: miCorreo@correo.com</param>
        /// <returns>La dirección de correo correspondiente a la direccion de correo real</returns>
        DireccionCorreo ObtenerDireccionDeCorreo(string pDireccionDeCorreo);
        /// <summary>
        /// Obtiene todas las direcciones de correo existentes en el sistema.
        /// </summary>
        /// <returns>Colección de todas las direcciones de correos existentes en el sistema</returns>
        IEnumerable<DireccionCorreo> ObtenerTodasLasDireccionesDeCorreo();
        /// <summary>
        /// Elimina un mensaje del sistema.
        /// </summary>
        /// <param name="pId">Identificador único del mensaje a eliminar</param>
        /// <returns>0 si no se pudo completar la operación, sino la operación fue exitosa</returns>
        int EliminarMensaje(int pId);
        /// <summary>
        /// Obtiene un mensje existente en el sistema.
        /// </summary>
        /// <param name="pId">Identificador único del mensaje</param>
        /// <returns>El mensaje correspondiente al identificador</returns>
        Mensaje ObtenerMensaje(int pId);
        /// <summary>
        /// Obtiene todos los mensajes existentes en el sistema.
        /// </summary>
        /// <returns>Colección de todos los mensajes existentes en el sistema</returns>
        IEnumerable<Mensaje> ObtenerTodosLosMensajes();
        /// <summary>
        /// Elimina una cuenta existente en el sistema.
        /// </summary>
        /// <param name="pId">Identificador único de la cuenta</param>
        /// <returns>0 si no se pudo completar la operación, sino la operación fue exitosa</returns>
        int EliminarCuenta(int pId);
        /// <summary>
        /// Elimina una cuenta existente en el sistema.
        /// </summary>
        /// <param name="pNombre">Nombre de la cuenta</param>
        /// <returns>0 si no se pudo completar la operación, sino la operación fue exitosa</returns>
        int EliminarCuenta(string pNombre);
        /// <summary>
        /// Obtiene una cuenta existente en el sistema.
        /// </summary>
        /// <param name="pId">Identificador único de la cuenta</param>
        /// <returns>La cuenta correspondiente al identificador</returns>
        Cuenta ObtenerCuenta(int pId);
        /// <summary>
        /// Obtiene una cuenta existente en el sistema.
        /// </summary>
        /// <param name="pNombre">Nombre de la cuenta</param>
        /// <returns>La cuenta correspondiente al nombre</returns>
        Cuenta ObtenerCuenta(string pNombre);
        /// <summary>
        /// Obtiene todas las cuentas existentes en el sistema.
        /// </summary>
        /// <returns>Colección de todas las cuentas existentes en el sistema</returns>
        IEnumerable<Cuenta> ObtenerTodasLasCuentas();
        /// <summary>
        /// Envía un correo mediante un protocolo de transmisión.
        /// </summary>
        /// <param name="pMensaje">Mensaje a enviar</param>
        /// <param name="pCuenta">Cuenta del usuario</param>
        /// <param name="pProtocoloTransmision">Protocolo de transmisión, ej: Smtp</param>
        void Enviar(Mensaje pMensaje, Cuenta pCuenta, IProtocoloTransmision pProtocoloTransmision);
        /// <summary>
        /// Recibe una cantidad de mensajes respectivos a una cuenta, mediante un protocolo de recepción.
        /// </summary>
        /// <param name="pCantidad">Cantidad de mensajes a descargar</param>
        /// <param name="pCuenta">Cuenta del usuario</param>
        /// <param name="pProtocoloRecepcion">Protocolo de recepcion que se utiliza para descargar los mensajes, ej: Pop3, IMAP</param>
        /// <param name="pBuzon">Entidad que almacena los mensajes descargados</param>
        void Recibir(int pCantidad, Cuenta pCuenta, IProtocoloRecepcion pProtocoloRecepcion, IBuzon pBuzon);
        /// <summary>
        /// Elimina un mensaje del servidor de correo respectivo a una cuenta, mediante un protocolo de recepción.
        /// </summary>
        /// <param name="pId">Identificador del mensaje en el servidor</param>
        /// <param name="pCuenta">Cuenta del usuario</param>
        /// <param name="pProtocoloRecepcion">Protocolo de recepcion que se utiliza para descargar los mensajes, ej: Pop3, IMAP</param>
        void EliminarDelServidor(int pId, Cuenta pCuenta, IProtocoloRecepcion pProtocoloRecepcion);
    }
}

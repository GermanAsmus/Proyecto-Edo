using CapaInterfaces.Modelo;
using CapaInterfaces.Servicio;
using CapaInterfaces.Utilidades;
using System.Collections.Generic;
using System.Threading;

namespace CapaInterfaces.Dominio
{
    /// <summary>
    /// Interfaz de la Fachada del Dominio.
    /// Todas las funcionalidades del programa se detallan en esta interfaz.
    /// </summary>
    public interface IControlador
    {
        IGestorRespositorios GestorRepositorios { get; }

        /// <summary>
        /// Agrega una cuenta nueva al sistema.
        /// </summary>
        /// <param name="pDireccion">Direccion de correo de la nueva cuenta</param>
        /// <param name="pCuenta">Nueva cuenta que se agregará al sistema</param>
        /// <param name="pServidor">Servidor de correo que utiliza la nueva cuenta</param>
        /// <returns>0 si no se pudo completar la operación, sino la operación fue exitosa</returns>
        int AregarCuenta(IDireccionCorreo pDireccion, ICuenta pCuenta);
        /// <summary>
        /// Confirma la edición de una cuenta ya existente en el sistema.
        /// </summary>
        /// <param name="pCuenta">Cuenta editada</param>
        /// <returns>0 si no se pudo completar la operación, sino la operación fue exitosa</returns>
        int EditarCuenta(ICuenta pCuenta);
        /// <summary>
        /// Confirma la edición de una dirección de correo ya existente en el sistema.
        /// </summary>
        /// <param name="pDireccionCorreo">Dirección de correo editada</param>
        /// <returns>0 si no se pudo completar la operación, sino la operación fue exitosa</returns>
        int EditarDireccionDeCorreo(IDireccionCorreo pDireccionCorreo);
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
        IDireccionCorreo ObtenerDireccionDeCorreo(int pId);
        /// <summary>
        /// Obtiene una direccion de correo existente en el sistema.
        /// </summary>
        /// <param name="pDireccionDeCorreo">Dirección de correo real de la dirección de correo, ej: miCorreo@correo.com</param>
        /// <returns>La dirección de correo correspondiente a la direccion de correo real</returns>
        IDireccionCorreo ObtenerDireccionDeCorreo(string pDireccionDeCorreo);
        /// <summary>
        /// Obtiene todas las direcciones de correo existentes en el sistema.
        /// </summary>
        /// <returns>Colección de todas las direcciones de correos existentes en el sistema</returns>
        IEnumerable<IDireccionCorreo> ObtenerTodasLasDireccionesDeCorreo();
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
        IMensaje ObtenerMensaje(int pId);
        /// <summary>
        /// Obtiene todos los mensajes existentes en el sistema.
        /// </summary>
        /// <returns>Colección de todos los mensajes existentes en el sistema</returns>
        IEnumerable<IMensaje> ObtenerTodosLosMensajes();
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
        ICuenta ObtenerCuenta(int pId);
        /// <summary>
        /// Obtiene una cuenta existente en el sistema.
        /// </summary>
        /// <param name="pNombre">Nombre de la cuenta</param>
        /// <returns>La cuenta correspondiente al nombre</returns>
        ICuenta ObtenerCuenta(string pNombre);
        /// <summary>
        /// Obtiene todas las cuentas existentes en el sistema.
        /// </summary>
        /// <returns>Colección de todas las cuentas existentes en el sistema</returns>
        IEnumerable<ICuenta> ObtenerTodasLasCuentas();
        /// <summary>
        /// Envía un correo mediante la cuenta del usuario.
        /// </summary>
        /// <param name="pMensaje">Mensaje a enviar</param>
        /// <param name="pCuenta">Cuenta del usuario</param>
        void Enviar(IMensaje pMensaje, ICuenta pCuenta);
        /// <summary>
        /// Recibe un mensaje.
        /// </summary>
        /// <param name="pCuenta">Cuenta del usuario</param>
        /// <param name="pBuzon">Entidad que almacena los mensajes descargados</param>
        void Recibir(int pIdMensaje, CancellationToken pCancellation, ICuenta pCuenta, ref IBuzon pBuzon);
        void Recibir(CancellationToken pCancellation, ICuenta pCuenta,ref IBuzon pBuzon);
        /// <summary>
        /// Elimina un mensaje del servidor de correo respectivo a una cuenta.
        /// </summary>
        /// <param name="pId">Identificador del mensaje en el servidor</param>
        /// <param name="pCuenta">Cuenta del usuario</param>
        void EliminarDelServidor(int pId, ICuenta pCuenta);
    }
}

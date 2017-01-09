using EdoUI.Entidades.DTO;
using System.Collections.Generic;

namespace EdoUI.Dominio
{
    public interface IControladorDominio
    {

        void CrearCuentaNueva(ICuenta pCuentaUsuario);
        ICollection<ICuenta> ListarCuentas();
        void EliminarCuentaSeleccionada(ICuenta pCuentaUsuario);
        void ActualizarInformacionCuentaSeleccionada(ICuenta pCuentaUsuario);

        ICollection<IMensaje> ListarMensajes(ICuenta pCuentaUsaurio);
        ICollection<ICuenta> ListarDestinatariosAsociados(ICuenta pCuentaUsuario);

        /// <summary>
        /// Crea un nuevo mensaje, y lo devuelve para ser posteriormente enviado.
        /// </summary>
        /// <param name="pMensajeNuevo"></param>
        /// <returns></returns>
        IMensaje CrearMensajeNuevo(IMensaje pMensajeNuevo);

        /// <summary>
        /// Elimina un mensaje de la bbdd y del servidor
        /// </summary>
        /// <param name="pMensaje"></param>
        void EliminarMensajeSeleccionado(IMensaje pMensaje);

        void ReenviarMensajeSeleccionado(IMensaje pMensaje);

        void EliminarCuentaDestinatarioSeleccionada(ICuenta pCuenta);
        /// <summary>
        /// Para una cuenta destinatario, se puede modificar sus datos como la direccion de correo asociada.
        /// </summary>
        /// <param name="pCuenta"></param>
        void ActualizarInformacionCuentaDestinatarioSeleccionada(ICuenta pCuenta);
        /// <summary>
        /// Completa cualquier accion referente de la conexion al servidor
        /// </summary>
        /// <param name="pCuentaUsuario"></param>
        /// <returns></returns>
        ICollection<IMensaje> Sincronizar(ICuenta pCuentaUsuario);
        ICollection<IMensaje> DescargarMenajes(ICuenta pCuentaUsuario);

        void EnviarMensaje(IMensaje pMensaje);
    }
}

using EdoUI.DTO;
using System.Collections.Generic;

namespace EdoUI.Dominio
{
    public interface IControladorDominio
    {

        void CrearCuentaNueva(ICuentaUsuarioDTO pCuentaUsuario);
        ICollection<ICuentaUsuarioDTO> ListarCuentas();
        void EliminarCuentaSeleccionada(ICuentaUsuarioDTO pCuentaUsuario);
        void ActualizarInformacionCuentaSeleccionada(ICuentaUsuarioDTO pCuentaUsuario);

        ICollection<IMensajeDTO> ListarMensajes(ICuentaUsuarioDTO pCuentaUsaurio);
        ICollection<ICuentaDTO> ListarDestinatariosAsociados(ICuentaUsuarioDTO pCuentaUsuario);

        /// <summary>
        /// Crea un nuevo mensaje, y lo devuelve para ser posteriormente enviado.
        /// </summary>
        /// <param name="pMensajeNuevo"></param>
        /// <returns></returns>
        IMensajeCompletoDTO CrearMensajeNuevo(IMensajeCompletoDTO pMensajeNuevo);

        /// <summary>
        /// Elimina un mensaje de la bbdd y del servidor
        /// </summary>
        /// <param name="pMensaje"></param>
        void EliminarMensajeSeleccionado(IMensajeDTO pMensaje);

        void ReenviarMensajeSeleccionado(IMensajeDTO pMensaje);

        void EliminarCuentaDestinatarioSeleccionada(ICuentaDTO pCuenta);
        /// <summary>
        /// Para una cuenta destinatario, se puede modificar sus datos como la direccion de correo asociada.
        /// </summary>
        /// <param name="pCuenta"></param>
        void ActualizarInformacionCuentaDestinatarioSeleccionada(ICuentaDTO pCuenta);
        /// <summary>
        /// Completa cualquier accion referente de la conexion al servidor
        /// </summary>
        /// <param name="pCuentaUsuario"></param>
        /// <returns></returns>
        ICollection<IMensajeDTO> Sincronizar(ICuentaUsuarioDTO pCuentaUsuario);
        ICollection<IMensajeDTO> DescargarMenajes(ICuentaUsuarioDTO pCuentaUsuario);

        void EnviarMensaje(IMensajeCompletoDTO pMensaje);
    }
}

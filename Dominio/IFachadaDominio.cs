using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IFachadaDominio
    {
        /// <summary>
        /// Crea una nueva cuenta de ususario y la persiste.
        /// </summary>
        /// <param name="pCuenta"></param>
        bool NuevaCuentaDeUsuario(ICuentaDeUsuarioDTO pCuenta);
        /// <summary>
        /// Elimina un cuenta de usuario persistida.
        /// </summary>
        /// <param name="pCuenta"></param>
        bool EliminarCuentaDeUsuario(ICuentaDeUsuarioDTO pCuenta);
        /// <summary>
        /// Obtiene todas las cuentas.
        /// </summary>
        /// <returns></returns>
        IEnumerable<ICuentaDeUsuarioDTO> ObtenerCuentas();
        /// <summary>
        /// Obtiene una cuenta por su id.
        /// </summary>
        /// <param name="pIdCuenta"></param>
        /// <returns></returns>
        ICuentaDeUsuarioDTO ObtenerUnaCuenta(int pIdCuenta);

        /// <summary>
        /// Envía un mensaje del usuario.
        /// También lo persiste.
        /// </summary>
        /// <param name="pCuenta"></param>
        /// <param name="pMensaje"></param>
        bool EnviarMensaje(ICuentaDeUsuarioDTO pCuenta, string pAsunto, ICollection<IDireccionCorreo> pDestinatario, string pContenido = "");
        /// <summary>
        /// Elimina un mensaje de la cuenta del usuario
        /// </summary>
        /// <param name="pCuenta"></param>
        /// <param name="pMensaje"></param>
        bool EliminarMensaje(ICuentaDeUsuarioDTO pCuenta, IMensajeDTO pMensaje);
        /// <summary>
        /// Descarga las cabeceras de los mensajes.
        /// </summary>
        /// <param name="pCuenta"></param>
        /// <param name="pCantidad"></param>
        /// <returns></returns>
        IEnumerable<IMensajeDTO> DescargarMensajes(ICuentaDeUsuarioDTO pCuenta, int pCantidad = 0);
        /// <summary>
        /// Descarga un mensaje particular, el mensaje es completo, es decir que tiene cuerpo.
        /// </summary>
        /// <param name="pIdMensaje"></param>
        /// <returns></returns>
        IMensajeDTO DescargarUnMensaje(ICuentaDeUsuarioDTO pCuenta, int pIdMensaje);
        /// <summary>
        /// Obtiene los mensajes persistidos.
        /// </summary>
        /// <param name="pCuenta"></param>
        /// <param name="pCantidad"></param>
        /// <returns></returns>
        IEnumerable<IMensajeDTO> ObtenerMensajes(ICuentaDeUsuarioDTO pCuenta);
        /// <summary>
        /// Obtiene un mensaje particular de la cuenta.
        /// </summary>
        /// <param name="pIdMensaje"></param>
        /// <returns></returns>
        IMensajeDTO ObtenerUnMensaje(ICuentaDeUsuarioDTO pCuenta, int pIdMensaje);

    }
}

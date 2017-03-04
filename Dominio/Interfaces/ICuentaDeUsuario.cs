using System;
using System.Collections.Generic;

namespace Dominio
{
    public interface ICuentaDeUsuario : IEntidadModelo
    {
        #region propiedades

        /// <summary>
        /// Refiere a la dirección de correo de la cuenta del usuario.
        /// </summary>
        IDireccionCorreo DireccionDeCorreo { get; set; }

        /// <summary>
        /// Identificador de la dirección de correo de la cuenta del usuario.
        /// </summary>
        byte DireccionId { get; set; }

        /// <summary>
        /// Contraseña de la cuenta del usuario
        /// </summary>
        string Contraseña { get; set; }

        /// <summary>
        /// Nombre que identifica a la cuenta
        /// </summary>
        string Nombre { get; set; }

        /// <summary>
        /// Servidor asociado a la cuenta. Mantiene los datos del servicio de mensajería remota.
        /// </summary>
        IServidor Servidor { get; set; }
        #endregion

        /// <summary>
        /// Crea un mensaje, lo almacena y lo envía.
        /// </summary>
        void EnviarMensaje(string pAsunto, ICollection<IDireccionCorreo> pDestinatario, string pContenido = "");

       /// <summary>
       /// Obtiene un mensaje que responde al un único identificador.
       /// La obtención puede ser local o remota.
       /// </summary>
       /// <param name="pIdMensaje">Identificador del mensaje</param>
       /// <param name="pRemoto">Valor que indica si la obtención es una descarga remota (true) o local (false)</param>
       /// <returns></returns>
        IMensaje ObtenerUnMensaje(int pIdMensaje, bool pRemoto = false);

        /// <summary>
        /// Obtiene una cantidad de mensajes.
        /// Si pRemoto es True: descarga solo las cabeceras de los mensajes.
        /// Si pRemoto es False: obtiene los n mensajes de la base de datos.
        /// </summary>
        /// <param name="pCantidad"></param>
        /// <param name="pRemoto"></param>
        /// <returns></returns>
        IEnumerable<IMensaje> ObtenerMenasjes(int pCantidad = 0, bool pRemoto = false);

        /// <summary>
        /// Elimina un mensaje mediante su id, No se elimina de la base de datos
        /// </summary>
        /// <param name="pIdMensaje">Id del mensaje</param>
        void EliminarMensaje(int pIdMensaje);


    }
}
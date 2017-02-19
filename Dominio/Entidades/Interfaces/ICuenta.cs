using System;
using System.Collections.Generic;

namespace Dominio.Entidades.Interfaces
{
    public interface ICuenta : IEntidadModelo
    {
        #region propiedades
        /// <summary>
        /// Refiere a la dirección de correo de la cuenta del usuario.
        /// </summary>
        IDireccionCorreo DireccionCorreo { get; set; }
        /// <summary>
        /// Identificador de la dirección de correo de la cuenta del usuario.
        /// </summary>
        int DireccionId { get; set; }
        /// <summary>
        ///Colección de mensjes que se relacionan con la cuenta.
        /// </summary>
        ICollection<IMensaje> Mensajes { get; set; }

        string Contraseña { get; set; }

        string Nombre { get; set; }

        /// <summary>
        /// Servidor asociado a la cuenta. Mantiene los datos del servicio de mensajería remota.
        /// </summary>
        IServidor Servidor { get; set; }
        #endregion

        /// <summary>
        /// Crea un mensaje y lo almacena en Mensajes (no envía el mensaje).
        /// </summary>
        IMensaje NuevoMensaje(string pAsunto, ICollection<ICuenta> pDestinatario, string pContenido = "");

        void NuevaDireccionDeCorreo(string pDireccion);
        IMensaje DescargarMensaje(int pIdMensaje);
        IEnumerable<IMensaje> Descargar(int pCantidad = 0);
        void EnviarMensaje(IMensaje pMensaje);
        void EliminarMensaje(int pIdMensaje);
    }
}
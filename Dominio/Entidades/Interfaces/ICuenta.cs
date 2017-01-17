using System.Collections.Generic;

namespace Dominio.Entidades.Interfaces
{
    public interface ICuenta : IEntidadModelo
    {
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
    }
}
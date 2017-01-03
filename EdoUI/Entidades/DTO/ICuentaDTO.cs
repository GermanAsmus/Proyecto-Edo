using System.Collections.Generic;

namespace EdoUI.Entidades.DTO
{
    public interface ICuentaDTO : IEntidadModelo
    {
        /// <summary>
        /// Refiere a la dirección de correo de la cuenta del usuario.
        /// </summary>
        IDireccionCorreoDTO DireccionCorreo { get; set; }
        /// <summary>
        /// Identificador de la dirección de correo de la cuenta del usuario.
        /// </summary>
        int DireccionId { get; set; }
        /// <summary>
        ///Colección de mensjes que se relacionan con la cuenta.
        /// </summary>
        ICollection<IMensajeDTO> Mensajes { get; set; }

/// <summary>
        /// Servidor asociado a la cuenta. Mantiene los datos del servicio de mensajería remota.
        /// </summary>
        IServidorDTO Servidor { get; set; }
    }
}
using System.Collections.Generic;

namespace EdoUI.Entidades.DTO
{
    /// <summary>
    /// Un Adjunto modela un archivo adjunto que pueda persistir en el sistema.
    /// </summary>
    public interface IAdjuntoDTO : IEntidadModelo
    {
        /// <summary>
        ///Path o dirección en donde el archivo adjunto se encuentra persistido en el disco.
        /// </summary>
        string PathAdjunto { get; set; }

        /// <summary>
        ///Colección de mensajes a los que el adjunto está relacionado.
        /// </summary>
        ICollection<IMensajeDTO> Mensajes { get; set; }
    }
}
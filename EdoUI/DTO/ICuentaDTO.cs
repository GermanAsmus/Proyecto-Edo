using System.Collections.Generic;

namespace EdoUI.DTO
{
    public interface ICuentaDTO : IEntidadModelo
    {
        IDireccionCorreoDTO DireccionCorreo { get; set; }

        int DireccionId { get; set; }

        ICollection<IMensajeDTO> Mensajes { get; set; }

        IServidorDTO Servidor { get; set; }
    }
}
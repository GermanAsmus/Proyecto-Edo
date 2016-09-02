using System.Collections.Generic;

namespace CapaInterfaces.Modelo
{
    public interface ICuentaDTO : IEntidadModelo
    {
        IDireccionCorreoDTO DireccionCorreo { get; set; }

        int DireccionId { get; set; }

        ICollection<IMensajeDTO> Mensajes { get; set; }

        IServidorDAO Servidor { get; set; }
    }
}
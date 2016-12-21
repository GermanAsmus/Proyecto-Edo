using System.Collections.Generic;

namespace EdoUI.DTO
{
    public interface IMensajeCompletoDTO : IMensajeDTO
    {
        ICollection<IAdjuntoDTO> Adjuntos { get; set; }
        string Contenido { get; set; }
    }
}
using System.Collections.Generic;

namespace EdoUI.Entidades.DTO
{
    public interface IMensajeCompleto : IMensaje
    {
        ICollection<IAdjunto> Adjuntos { get; set; }
        string Contenido { get; set; }
    }
}
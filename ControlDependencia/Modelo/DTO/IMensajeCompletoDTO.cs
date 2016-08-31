using System.Collections.Generic;

namespace CapaInterfaces.Modelo
{
    public interface IMensajeCompletoDTO : IMensajeDTO
    {
        ICollection<IAdjuntoDTO> Adjuntos { get; set; }
        string Contenido { get; set; }
    }
}
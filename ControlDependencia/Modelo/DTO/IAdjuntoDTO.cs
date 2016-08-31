using System.Collections.Generic;

namespace CapaInterfaces.Modelo
{
    public interface IAdjuntoDTO : IEntidadModelo
    {
        string PathAdjunto { get; set; }
        //Colección de mensajes a los que el adjunto está relacionado.
        ICollection<IMensajeDTO> Mensajes { get; set; }
    }
}
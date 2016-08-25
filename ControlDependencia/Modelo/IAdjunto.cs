using System.Collections.Generic;

namespace CapaInterfaces.Modelo
{
    public interface IAdjunto:IEntidadModelo
    {
        string CodigoAdjunto { get; set; }
        //Colección de mensajes a los que el adjunto está relacionado.
        ICollection<IMensaje> Mensajes { get; set; }
    }
}
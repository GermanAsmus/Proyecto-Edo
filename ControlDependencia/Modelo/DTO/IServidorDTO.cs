using System.Collections.Generic;

namespace CapaInterfaces.Modelo
{
    public interface IServidorDTO
    {
        //Nombre del servidor.
        string Nombre { get; set; }
        
        //Protocolos que utiliza el servidor.
        ICollection<IProtocoloDTO> Protocolos { get; set; }        
    }
}
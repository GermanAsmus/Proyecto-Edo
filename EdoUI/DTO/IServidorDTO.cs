using System.Collections.Generic;

namespace EdoUI.DTO
{ 
    public interface IServidorDTO
    {
        //Tipo del servidor.
        string Nombre { get; set; }
        
        //Protocolos que utiliza el servidor.
        ICollection<IProtocoloDTO> Protocolos { get; set; }        
    }
}
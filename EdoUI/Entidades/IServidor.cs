using System.Collections.Generic;

namespace EdoUI.Entidades.DTO
{ 
    public interface IServidor
    {
        //Tipo del servidor.
        string Nombre { get; set; }
        
        //Protocolos que utiliza el servidor.
        ICollection<IProtocolo> Protocolos { get; set; }        
    }
}
using System.Collections.Generic;

namespace CapaInterfaces.Modelo
{
    public interface IServidor
    {
        //Nombre del servidor.
        string Nombre { get; set; }
        //Protocolos de comunicacion del servidor
        IEnumerable<IProtocolo> Protocolos { get; set; }

        IProtocolo ObtenerProtocolo(string nombre);
    }
}
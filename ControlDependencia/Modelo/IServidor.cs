using System.Collections.Generic;

namespace CapaInterfaces.Modelo
{
    public interface IServidor
    {
        //Nombre del servidor.
        string Nombre { get; }
        //Protocolos de comunicacion del servidor
        //IEnumerable<IProtocolo> Protocolos { get; }

        IProtocolo ObtenerProtocolo(string nombre);
    }
}
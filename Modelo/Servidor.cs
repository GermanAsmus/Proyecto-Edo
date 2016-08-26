using CapaInterfaces.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace Modelo
{
    /// <summary>
    /// Entidad Servidor, modela un servidor de correo. Ej: gmail, yahoo, hotmail.
    /// </summary>
    public class Servidor : IServidor
    {
        //Nombre del servidor.
        public string Nombre { get; set; }
        //Protocolos de comunicacion del servidor
        public IEnumerable<IProtocolo> Protocolos { get; set; }

        public Servidor()
        {
        }

        public IProtocolo ObtenerProtocolo(string nombre)
        {
            return this.Protocolos.FirstOrDefault(p => p.Nombre == nombre.ToLower());
        }
    }
}

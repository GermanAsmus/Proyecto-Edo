using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    /// <summary>
    /// Entidad Servidor, modela un servidor de correo. Ej: gmail, yahoo, hotmail.
    /// </summary>
    public class Servidor
    {
        //Nombre del servidor.
        public string Nombre { get; set; }
        //Protocolos de comunicacion del servidor
        public IEnumerable<Protocolo> Protocolos { get; set; }

        public Servidor()
        {
        }

        public Protocolo ObtenerProtocolo(string nombre)
        {
            return this.Protocolos.FirstOrDefault(p => p.Nombre == nombre.ToLower());
        }
    }
}

using System.Collections.Generic;

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
    }
}

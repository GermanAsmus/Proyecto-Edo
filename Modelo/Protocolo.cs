using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Protocolo
    {
        public Protocolo()
        {

        }
        //Host del servidor.
        public string Host { get; set; }
        //Puerto del servidor.
        public int Puerto { get; set; }
        //SSL, capa de puertos de seguridad, del servidor.
        public bool SSL { get; set; }
    }
}

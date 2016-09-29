using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ServidorDTO : IServidorDTO
    {
        //Tipo del servidor.
        public string Nombre { get; set; }

        //Protocolos de comunicacion del servidor
        public ICollection<IProtocoloDTO> Protocolos { get; set; }

        public ServidorDTO()
        {
            this.Protocolos = new List<IProtocoloDTO>();
        }
    }
}

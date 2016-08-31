using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaInterfaces.Modelo
{
    public interface IServidorDAO
    {
        IProtocoloDTO ObtenerProtocolo(string nombre);
    }
}

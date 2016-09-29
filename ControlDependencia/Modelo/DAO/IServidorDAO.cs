using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaInterfaces.Modelo
{
    public interface IServidorDAO : IEntidadDAO<IProtocoloDTO>
    {
        IServidorDTO ServidorDTO { get; set; }
    }
}

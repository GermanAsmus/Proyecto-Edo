using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public interface IServidorFactory
    {
        ICollection<IProtocolo> AgregarProtocolo();
    }
}
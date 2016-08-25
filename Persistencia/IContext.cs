using System.Data.Entity.Infrastructure;

namespace Persistencia
{
    public interface IContext : CapaInterfaces.Persistencia.IContext, IObjectContextAdapter
    {
    }
}
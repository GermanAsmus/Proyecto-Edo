using System.Data.Entity.Infrastructure;

namespace Persistencia
{
    public interface IContext : ControlDependencia.Persistencia.IContext, IObjectContextAdapter
    {
    }
}
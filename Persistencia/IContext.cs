using System.Data.Entity.Infrastructure;

namespace Persistencia
{
    public interface IContext : IObjectContextAdapter
    {
        int Commit();
        void Dispose();
    }
}
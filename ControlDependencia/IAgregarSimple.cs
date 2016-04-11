using System.Threading.Tasks;

namespace ControlDependencia
{
    public interface IAgregarSimple<T1> : IAgregar
    where T1 : class
    {
        Task Agregar(T1 entidad);
    }
}

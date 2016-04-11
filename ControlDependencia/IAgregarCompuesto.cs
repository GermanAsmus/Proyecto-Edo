using System.Threading.Tasks;

namespace ControlDependencia
{
    public interface IAgregarCompuesto<T1, T2> : IAgregar
        where T1 : class
        where T2 : class
    {
        Task Agregar(T1 hijo, T2 padre);
    }
}

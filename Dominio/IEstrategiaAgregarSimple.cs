using ControlDependencia;

namespace Dominio
{
    public interface IEstrategiaAgregarSimple<T> : IRepositorio<T> where T : class
    {
        new int Agregar(T entidad);
    }
}

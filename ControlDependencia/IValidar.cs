using Modelo;

namespace ControlDependencia
{
    public interface IValidar<T> where T : class
    {
        T Evaluar(T pEntidad, IRepositorio<T> pRepositorio);
    }
}

using Modelo;

namespace ControlDependencia
{
    public interface IAgregarCompuesto<T1, T2> : IAgregar
        where T1 : class
        where T2 : class
    {
        void Agregar(T1 hijo, T2 padre);
    }
}

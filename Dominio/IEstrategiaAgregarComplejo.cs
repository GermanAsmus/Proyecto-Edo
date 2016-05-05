using ControlDependencia;

namespace Dominio
{
    public interface IEstrategiaAgregarComplejo<T1, T2> : IRepositorio<T1>
        where T1 : class
        where T2 : class
    {
        int Agregar(T1 pHijo, T2 pPadre);
    }
}

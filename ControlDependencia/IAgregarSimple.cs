namespace ControlDependencia
{
    public interface IAgregarSimple<T1> : IAgregar
    where T1 : class
    {
        void Agregar(T1 entidad);
    }
}

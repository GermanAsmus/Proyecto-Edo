namespace CapaInterfaces
{
    public interface ICreador<T> where T : class
    {
        T ObtenerEntidad();
    }
}
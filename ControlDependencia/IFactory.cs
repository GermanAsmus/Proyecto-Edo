namespace CapaInterfaces
{
    public interface IFactory<T> where T : class
    {
        T AgregarEntidad();
    }
}
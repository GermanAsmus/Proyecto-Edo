namespace Modelo
{
    public interface IStatePersistencia : IRegistrable
    {
        EstadoPersistencia ObtenerEstadoPersistencia();
    }
}

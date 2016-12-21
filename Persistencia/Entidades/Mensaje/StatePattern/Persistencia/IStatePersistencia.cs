namespace Modelo
{
    public interface IStatePersistencia : IRegistrableCollection
    {
        EstadoPersistencia ObtenerEstadoPersistencia();
    }
}

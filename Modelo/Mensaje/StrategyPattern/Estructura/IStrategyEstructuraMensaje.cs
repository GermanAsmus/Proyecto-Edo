namespace Modelo
{
    public interface IStrategyEstructuraMensaje
    {
        IStrategyPertenenciaMensaje Pertenencia { get; }

        string ObtenerEstadoPertenecia { get; }
    }
}

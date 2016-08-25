namespace Modelo
{
    public interface IStrategyEstructuraMensaje
    {
        IStrategyPertenenciaMensaje Pertenencia { get; }

        string ObtenerPertenecia { get; }
    }
}

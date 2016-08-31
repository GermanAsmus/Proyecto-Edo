using CapaInterfaces.Modelo;

namespace Modelo
{
    public interface IStrategyPertenenciaMensaje
    {
        ICuentaDAO Cuenta { get; set; }
        EstrategiaPertenencia ObtenerEstrategiaPertenencia();
    }
}
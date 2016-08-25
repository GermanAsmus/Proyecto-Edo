using CapaInterfaces.Modelo;

namespace Modelo
{
    public interface IStrategyPertenenciaMensaje
    {
        ICuenta Cuenta { get; set; }
        EstrategiaPertenencia ObtenerEstrategiaPertenencia();
    }
}
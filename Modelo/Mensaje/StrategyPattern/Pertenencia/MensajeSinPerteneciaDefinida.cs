using CapaInterfaces.Modelo;

namespace Modelo
{
    public abstract class MensajeSinPerteneciaDefinida : IStrategyPertenenciaMensaje
    {
        public ICuenta Cuenta { get; set; }

        public abstract EstrategiaPertenencia ObtenerEstrategiaPertenencia();

        public MensajeSinPerteneciaDefinida(ICuenta pCuenta)
        {

        }
    }
}

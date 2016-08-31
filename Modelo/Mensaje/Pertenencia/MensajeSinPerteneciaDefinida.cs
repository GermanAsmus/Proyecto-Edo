using CapaInterfaces.Modelo;

namespace Modelo
{
    public abstract class MensajeSinPerteneciaDefinida : IStrategyPertenenciaMensaje
    {
        public ICuentaDAO Cuenta { get; set; }

        public abstract EstrategiaPertenencia ObtenerEstrategiaPertenencia();

        public MensajeSinPerteneciaDefinida(ICuentaDAO pCuenta)
        {

        }
    }
}

using CapaInterfaces.Modelo;

namespace Modelo
{
    public class MensajeExterno : IStrategyPertenenciaMensaje
    {
        public ICuenta Cuenta
        {
            get { return Cuenta; }
            set { this.Cuenta = value; }
        }

        public IStateVisibilidad Visibilidad { get; private set; }

        public IStateVisibilidad CambiarVisibilidad()
        {
            if (Visibilidad.ObtenerEstadoVisibilidad() == EstadoVisibilidad.Visto)
                this.Visibilidad = new MensajeNoVisto();
            else
                this.Visibilidad = new MensajeVisto();

            return this.Visibilidad;
        }

        //Constructor de la clase
        public MensajeExterno(ICuenta pCuenta)
        {
            //Se verifica que la cuenta que referencia el mensaje sea una cuenta externa
            if (pCuenta.GetType() != typeof(CuentaExterna))
                throw new TipoCuentaException(
                    string.Format(
                    "La cuenta a la que referencia el mensaje debería ser del tipo {0}, pero no lo es.",
                    typeof(CuentaExterna)));
            this.Cuenta = pCuenta;
        }
    }
}

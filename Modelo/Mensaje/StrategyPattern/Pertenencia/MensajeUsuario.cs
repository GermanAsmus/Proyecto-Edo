using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MensajeUsuario : MensajeSinPerteneciaDefinida
    {
        public IStateComunicacion Comunicacion { get; private set; }

        public IStateComunicacion CambiarComunicacion()
        {
            if (Comunicacion.ObtenerEstadoComunicacion() == EstadoComunicacion.Enviado)
                this.Comunicacion = new MensajeNoEviado();
            else
                this.Comunicacion = new MensajeEnviado();

            return this.Comunicacion;
        }

        public string ObtenerComunicacion()
        {
            return this.Comunicacion.ObtenerEstadoComunicacion().ToString();
        }

        public override EstrategiaPertenencia ObtenerEstrategiaPertenencia()
        {
            return EstrategiaPertenencia.Usuario;
        }

        //Constructor de la clase
        public MensajeUsuario(ICuenta pCuenta) : base(pCuenta)
        {
            //refactorizado código :)
            var type = typeof(CuentaUsuario);

            //Se verifica que la cuenta que referencia el mensaje sea una cuenta del usuario
            if (pCuenta.GetType() != type)
                throw new TipoCuentaException(
                    string.Format(
                    "La cuenta a la que referencia el mensaje debería ser del tipo {0}, pero no lo es.",
                    type));
            this.Cuenta = pCuenta;
        }
    }
}

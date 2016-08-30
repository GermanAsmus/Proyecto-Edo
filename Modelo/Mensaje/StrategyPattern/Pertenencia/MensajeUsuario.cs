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
        public ICollection<IRegistroMensaje<EstadoComunicacion>> RegistroComunicacion { get; private set; }

        private void CambiarEstadoComunicacion(EstadoComunicacion pComunicacion)
        {
            if (this.RegistroComunicacion == null)
                this.RegistroComunicacion = new List<IRegistroMensaje<EstadoComunicacion>>();

            this.RegistroComunicacion.Add(new RegistroMensaje<EstadoComunicacion>(pComunicacion));
        }

        public EstadoComunicacion CambiarEstadoComunicacion()
        {
            if (this.ObtenerEstadoComunicacion() != EstadoComunicacion.Enviado)
                this.CambiarEstadoComunicacion(EstadoComunicacion.Enviado);
            else
                this.CambiarEstadoComunicacion(EstadoComunicacion.No_Enviado);

            return this.ObtenerEstadoComunicacion();
        }

        public EstadoComunicacion ObtenerEstadoComunicacion()
        {
            return this.RegistroComunicacion.Last().Registro;
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

            this.CambiarEstadoComunicacion(EstadoComunicacion.No_Enviado);
        }
    }
}

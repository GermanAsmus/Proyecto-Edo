using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace Modelo
{
    public class MensajeExterno : MensajeSinPerteneciaDefinida
    {
        public ICollection<IRegistroMensaje<EstadoVisibilidad>> RegistroVisibiliadad { get; private set; }

        //Cambia el estado de la visibilidad del mensaje, agregando el cambio como un nuevo registro.
        private void CambiarEstadoVisibilidad(EstadoVisibilidad pVisibilidad)
        {
            if (this.RegistroVisibiliadad == null)
                this.RegistroVisibiliadad = new List<IRegistroMensaje<EstadoVisibilidad>>();

            this.RegistroVisibiliadad.Add(new RegistroMensaje<EstadoVisibilidad>(pVisibilidad));
        }
        //Cambia el estado de la visibilidad del mensaje.
        public EstadoVisibilidad CambiarEstadoVisibilidad()
        {
            if (this.ObtenerEstadoVisibilidad() != EstadoVisibilidad.Visto)
                this.CambiarEstadoVisibilidad(EstadoVisibilidad.Visto);
            else
                this.CambiarEstadoVisibilidad(EstadoVisibilidad.No_Visto);

            return this.ObtenerEstadoVisibilidad();
        }
        //Se devuelve el estado de visibilidad del mensaje.
        public EstadoVisibilidad ObtenerEstadoVisibilidad()
        {
            return this.RegistroVisibiliadad.Last().Registro;
        }
        //Se devuelve si el mensaje es externo o del usuario.
        public override EstrategiaPertenencia ObtenerEstrategiaPertenencia()
        {
            return EstrategiaPertenencia.Externo;
        }

        //Constructor de la clase
        public MensajeExterno(ICuenta pCuenta) : base(pCuenta)
        {
            //Se verifica que la cuenta que referencia el mensaje sea una cuenta externa
            if (pCuenta.GetType() != typeof(CuentaExterna))
                throw new TipoCuentaException(
                    string.Format(
                    "La cuenta a la que referencia el mensaje debería ser del tipo {0}, pero no lo es.",
                    typeof(CuentaExterna)));
            this.Cuenta = pCuenta;

            this.CambiarEstadoVisibilidad(EstadoVisibilidad.No_Visto);
        }

    }
}

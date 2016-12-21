using EdoUI.DTO;
using System.Collections.Generic;

namespace Persistencia.Entidades.Cuenta.Pertenencia
{
    public class CuentaExterna : CuentaDAO
    {
        public CuentaExterna(ICuentaDTO pCuentaDTO) : base(pCuentaDTO) { }
        public override ICuentaDTO Cuenta
        {
            get
            {
                return base.Cuenta;
            }

            set
            {
                base.Cuenta = value;
            }
        }
    }
}

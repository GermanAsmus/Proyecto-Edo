using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Persistencia
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

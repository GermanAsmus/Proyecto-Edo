using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Persistencia
{
    public class CuentaUsuario : CuentaDAO
    {
        public CuentaUsuario(ICuentaDTO pCuentaDTO) : base(pCuentaDTO) { }
        public override ICuentaDTO Cuenta
        {
            get
            {
                return base.Cuenta as ICuentaUsuarioDTO;
            }

            set
            {
                base.Cuenta = value as ICuentaUsuarioDTO;
            }
        }

    }
}

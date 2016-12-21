using EdoUI.DTO;

namespace Persistencia.Entidades.Cuenta.Pertenencia
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

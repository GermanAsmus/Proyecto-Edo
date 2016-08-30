using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CuentaExterna : Cuenta
    {
        public CuentaExterna(ICuentaFactory pCuentaFactory, string pDireccion) : base(pCuentaFactory, pDireccion) { }
        protected override void RealizarCuenta()
        {
            this.Servidor = new ServidorNulo(null);
        }
    }
}

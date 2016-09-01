using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CuentaExternaDAO : CuentaDAO
    {
        public CuentaExternaDAO(ICuentaFactory pCuentaFactory, string pDireccion) : base(pCuentaFactory, pDireccion) { }

        //protected override void RealizarCuenta()
        //{
        //    this.CuentaDTO.Servidor = new ServidorNulo(null).ServidorDTO;
        //}
    }
}

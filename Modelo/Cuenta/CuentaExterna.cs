using CapaInterfaces.Modelo;

namespace Modelo
{
    public class CuentaExterna : CuentaDAO
    {
        public CuentaExterna(ICuentaFactory pCuentaFactory, string pDireccion) : base(pCuentaFactory, pDireccion) { }

        //protected override void RealizarCuenta()
        //{
        //    this.CuentaDTO.Servidor = new ServidorNulo(null).ServidorDTO;
        //}
    }
}

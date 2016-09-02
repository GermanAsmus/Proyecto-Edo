using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public class CuentaExternaDAO : CuentaDAO
    {
        //public CuentaExternaDAO(CuentaFactory pCuentaFactory) : base(pCuentaFactory) { }
        public CuentaExternaDAO(ICuentaDTO pCuentaDTO) : base(pCuentaDTO)
        {
            this.CuentaDTO = pCuentaDTO;

            string host = DireccionCorreo.ObtenerHost(this.CuentaDTO.DireccionCorreo);

            this.iServicioControlMensajes = new EntidadDAO<IMensajeDTO>(this.CuentaDTO.Mensajes);

            this.iCuentaFactory = new CuentaFactory(host);
            this.RealizarCuenta();
        }
        public override ICuentaDTO CuentaDTO
        {
            get
            {
                return base.CuentaDTO;
            }

            set
            {
                base.CuentaDTO = value;
            }
        }
    }
}

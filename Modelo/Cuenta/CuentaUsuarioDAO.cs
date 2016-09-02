using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Modelo
{
    public class CuentaUsuarioDAO : CuentaDAO
    {
        public CuentaUsuarioDAO(ICuentaDTO pCuentaDTO) : base(pCuentaDTO)
        {
            this.CuentaDTO = pCuentaDTO as ICuentaUsuarioDTO;

            string host = DireccionCorreo.ObtenerHost(this.CuentaDTO.DireccionCorreo);

            this.iServicioControlMensajes = new EntidadDAO<IMensajeDTO>(this.CuentaDTO.Mensajes);

            this.iCuentaFactory = new CuentaFactory(host);
            this.RealizarCuenta();
        }
        public override ICuentaDTO CuentaDTO
        {
            get
            {
                return base.CuentaDTO as ICuentaUsuarioDTO;
            }

            set
            {
                base.CuentaDTO = value as ICuentaUsuarioDTO;
            }
        }
    }
}

using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public class CreadorCuentaExterna : CreadorCuenta
    {
        public CreadorCuentaExterna(string pDireccion, ICollection<IMensajeDTO> pMensajes) : base(pDireccion, pMensajes)
        {
            this.iCuentaDTO = new CuentaDTO()
            {
                DireccionCorreo = new DireccionCorreo(pDireccion),
                Mensajes = pMensajes
            };
        }

        protected override ICuentaDTO iCuentaDTO { get; set; }

        protected override ICuentaDAO CrearEntidad()
        {
            //CuentaFactory factoryCuenta = new CuentaFactory();
            //return new CuentaExternaDAO(factoryCuenta);
            return new CuentaExternaDAO(this.iCuentaDTO);
        }
    }
}
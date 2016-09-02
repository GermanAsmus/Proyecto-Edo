using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    public abstract class CreadorCuenta : Creador<ICuentaDAO>
    {
        protected virtual ICuentaDTO iCuentaDTO { get; set; }
        public CreadorCuenta(string pDireccion, ICollection<IMensajeDTO> pMensajes) : base()
        {

        }
    }
}
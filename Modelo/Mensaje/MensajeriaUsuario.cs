using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class MensajeriaUsuario : Mensajeria
    {
        public override IMensajeDAO CrearMensaje(IMensajeCompletoDTO pMensajeDTO)
        {
            throw new NotImplementedException();
        }

        public override IMensajeDAO CrearMensaje(IMensajeDTO pMensajeDTO)
        {
            throw new NotImplementedException();
        }

        public override IMensajeDAO CrearMensaje(ICuentaDTO pCuentaDTO, string pAsunto, ICuentaDTO pDestinatario)
        {
            throw new NotImplementedException();
        }

        public override IMensajeDAO CrearMensaje(ICuentaDTO pCuentaDTO, string pAsunto, ICollection<ICuentaDTO> pDestinatario, string pContenido)
        {
            throw new NotImplementedException();
        }

        public override IMensajeDAO CrearMensaje(ICuentaDTO pCuentaDTO, string pAsunto, ICollection<ICuentaDTO> pDestinatario, string pContenido, ICollection<IAdjuntoDTO> pAdjuntos)
        {
            throw new NotImplementedException();
        }
    }
}

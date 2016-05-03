using ControlDependencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Servicio
{
    public class Protocolo : IProtocolo
    {
        public void Descargar(int pCantidad, IProtocoloRecepcion pProtocoloRecepcion)
        {
            pProtocoloRecepcion.Descargar(pCantidad);
        }
        public void Eliminar(int pId, IProtocoloRecepcion pProtocoloRecepcion)
        {
            pProtocoloRecepcion.Eliminar(pId);
        }
        public void Enviar(Mensaje pMensaje, IProtocoloTransmision pProtocoloRecepcion)
        {
            //pProtocoloRecepcion.Enviar(pMensaje);
        }
    }
}

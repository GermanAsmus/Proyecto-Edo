using ControlDependencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using ControlDependencia.Servicio;
using System.Threading;

namespace Servicio
{
    public class Protocolo : IProtocolo
    {
        public void Descargar(int pIdMensaje,CancellationToken pCancellation, IProtocoloRecepcion pProtocoloRecepcion)
        {
            pProtocoloRecepcion.Descargar(pIdMensaje,pCancellation);
        }
        public void Descargar(CancellationToken pCancellation, IProtocoloRecepcion pProtocoloRecepcion)
        {
            pProtocoloRecepcion.Descargar(pCancellation);
        }
        public void Eliminar(int pId, IProtocoloRecepcion pProtocoloRecepcion)
        {
            pProtocoloRecepcion.Eliminar(pId);
        }
        public void Enviar(Mensaje pMensaje, Cuenta pCuenta, IProtocoloTransmision pProtocoloTransmision)
        {
            pProtocoloTransmision.Enviar(pMensaje,pCuenta);
        }
    }
}

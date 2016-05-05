using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Net.Mail;
using ControlDependencia;

namespace Servicio
{
    public class Servicio : IServicio
    {
        public IProtocolo iProtocolo { get; }
        public Cuenta CuentaServicio { get; set; }

        public Servicio(IProtocolo pProtocolo)
        {
            iProtocolo = pProtocolo;
        }

        public void Descargar(int pCantidad, IProtocoloRecepcion pProtocoloRecepcion, IBuzon pBuzon)
        {
            pProtocoloRecepcion.CuentaUsuario = CuentaServicio;
            pProtocoloRecepcion.Buzon = pBuzon;
            this.iProtocolo.Descargar(pCantidad,pProtocoloRecepcion);
        }

        public void Eliminar(int pUid, IProtocoloRecepcion pProtocoloRecepcion)
        {
            pProtocoloRecepcion.CuentaUsuario = CuentaServicio;
            this.iProtocolo.Eliminar(pUid, pProtocoloRecepcion);
        }

        public void Enviar(Mensaje pMensaje, IProtocoloTransmision pProtocoloTransmision)
        {
            this.iProtocolo.Enviar(pMensaje,this.CuentaServicio,pProtocoloTransmision);
        }
    }
}

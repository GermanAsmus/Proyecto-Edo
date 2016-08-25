using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Net.Mail;
using CapaInterfaces;
using CapaInterfaces.Servicio;
using CapaInterfaces.Utilidades;
using System.Threading;

namespace Servicio
{
    public class Servicio : IServicio
    {
        public IProtocolo iProtocolo { get; set; }

        public Servicio(IProtocolo pProtocolo)
        {
            iProtocolo = pProtocolo;
        }

        public void Descargar(int pIdMensaje,CancellationToken pCancellation, Cuenta pCuenta, IProtocoloRecepcion pProtocoloRecepcion,ref IBuzon pBuzon)
        {
            pProtocoloRecepcion.CuentaUsuario = pCuenta;
            pProtocoloRecepcion.Buzon = pBuzon;
            this.iProtocolo.Descargar(pIdMensaje,pCancellation, pProtocoloRecepcion);
        }
        public void Descargar(CancellationToken pCancellation, Cuenta pCuenta, IProtocoloRecepcion pProtocoloRecepcion,ref IBuzon pBuzon)
        {
            pProtocoloRecepcion.CuentaUsuario = pCuenta;
            pProtocoloRecepcion.Buzon = pBuzon;
            this.iProtocolo.Descargar(pCancellation, pProtocoloRecepcion);
        }

        public void Eliminar(int pUid, Cuenta pCuenta, IProtocoloRecepcion pProtocoloRecepcion)
        {
            pProtocoloRecepcion.CuentaUsuario = pCuenta;
            this.iProtocolo.Eliminar(pUid, pProtocoloRecepcion);
        }

        public void Enviar(Mensaje pMensaje, Cuenta pCuenta, IProtocoloTransmision pProtocoloTransmision)
        {
            this.iProtocolo.Enviar(pMensaje, pCuenta, pProtocoloTransmision);
        }
    }
}

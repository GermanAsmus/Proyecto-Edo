using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Net.Mail;
using ControlDependencia;
using ControlDependencia.Servicio;
using ControlDependencia.Utilidades;

namespace Servicio
{
    public class Servicio : IServicio
    {
        public IProtocolo iProtocolo { get; set; }

        public Servicio(IProtocolo pProtocolo)
        {
            iProtocolo = pProtocolo;
        }

        public void Descargar(int pCantidad, Cuenta pCuenta, IProtocoloRecepcion pProtocoloRecepcion, IBuzon pBuzon)
        {
            pProtocoloRecepcion.CuentaUsuario = pCuenta;
            pProtocoloRecepcion.Buzon = pBuzon;
            this.iProtocolo.Descargar(pCantidad, pProtocoloRecepcion);
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

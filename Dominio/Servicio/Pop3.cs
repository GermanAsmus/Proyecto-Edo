using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using Dominio.Entidades.Interfaces;
using Dominio.Entidades;
using System.Linq;
using Servicio;
using System.Net.Mail;

namespace Dominio.Servicio
{

    public class Pop3 : Protocolo, IProtocoloRecepcion
    {
        public int CantidadDescargas { get; set; }

        public void Eliminar(int pIdMensaje, string pDireccion, string pContraseña)
        {
            ProtocoloPop3 aProtocolo = new ProtocoloPop3(
                pDireccion,
                pContraseña,
                this.Host,
                this.Puerto,
                this.SSL);

            aProtocolo.Eliminar(pIdMensaje);
        }

        public IEnumerable<IMensaje> Descargar(string pDireccion, string pContraseña)
        {
            ProtocoloPop3 aProtocolo = new ProtocoloPop3(
                pDireccion,
                pContraseña,
                this.Host,
                this.Puerto,
                this.SSL);

            ICollection<IMensaje> aMensajes = new List<IMensaje>();

            aProtocolo.DescargarCabeceras(CantidadDescargas).ToList().ForEach((mm => aMensajes.Add(new Mensaje(mm))));

            return aMensajes;
        }

        public IMensaje Descargar(int pIdMensaje, string pDireccion, string pContraseña)
        {
            ProtocoloPop3 aProtocolo = new ProtocoloPop3(
                 pDireccion,
                 pContraseña,
                 this.Host,
                 this.Puerto,
                 this.SSL);

            return new Mensaje(aProtocolo.Descargar(pIdMensaje));
        }
    }
}

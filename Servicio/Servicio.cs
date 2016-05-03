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
        private IDictionary<string, IProtocolo> iProtocolos;
        public IBuzon BuzonServicio { get; }
        public Cuenta CuentaServicio { get; }

        public Servicio(IDictionary<string, IProtocolo> pProtocolos)
        {
            iProtocolos = pProtocolos;
        }

        public void Descargar(int pCantidad, string pNombreProtocolo)
        {
            //Pop3 pop = new Pop3(CuentaServicio, BuzonServicio);
            //pop.DescargarCabeceras(pCantidad);
            //pop.DescargarMensaje(pCantidad);
        }

        public void Eliminar(int pUid, string pNombreProtocolo)
        {
            //Pop3 pop = new Pop3(CuentaServicio, BuzonServicio);
            //pop.EliminarMensaje(pUid);
        }

        public void Enviar(Mensaje pMensaje, string pNombreProtocolo)
        {
            //Smtp smtp = new Smtp(CuentaServicio);
            //smtp.Enviar(pMensaje);
        }

    }
}

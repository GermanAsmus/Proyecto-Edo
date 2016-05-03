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
    public class Conexion : IServicio
    {
        public IBuzon BuzonServicio
        {
            get { return BuzonServicio; }
        }

        public Cuenta CuentaServicio
        {
            get { return CuentaServicio; }
        }

        public void Descargar(int pCantidad)
        {
            Pop3 pop = new Pop3(CuentaServicio,BuzonServicio);
            pop.DescargarCabeceras(pCantidad);
            pop.DescargarMensaje(pCantidad);
        }

        public void Eliminar(int pUid)
        {
            Pop3 pop = new Pop3(CuentaServicio, BuzonServicio);
            pop.EliminarMensaje(pUid);
        }

        public void Enviar(Mensaje pMensaje)
        {
            Smtp smtp = new Smtp(CuentaServicio);
            smtp.Enviar(pMensaje);
        }
    }
}

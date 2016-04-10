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
    public class Conexion : IConexion
    {
        public Buzon BuzonServicio
        {
            get { return BuzonServicio; }
        }

        public Cuenta CuentaServicio
        {
            get { return CuentaServicio; }
        }

        public void Descargar(int cantidad)
        {
            Pop3 pop = new Pop3(CuentaServicio,BuzonServicio);
            Task.Factory.StartNew(()=> pop.DescargarCabeceras(cantidad));
            Task.Factory.StartNew(() => pop.DescargarMensaje(cantidad));
        }

        public void Eliminar(int pUid)
        {
            Pop3 pop = new Pop3(CuentaServicio, BuzonServicio);
            Task.Factory.StartNew(()=> pop.EliminarMensaje(pUid));
        }

        public void Enviar(Completo mensaje)
        {
            Smtp smtp = new Smtp(CuentaServicio);
            Task.Factory.StartNew(() => smtp.Enviar(mensaje));
        }
    }
}

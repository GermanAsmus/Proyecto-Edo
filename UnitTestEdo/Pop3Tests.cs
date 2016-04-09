using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.Tests
{
    [TestClass()]
    public class Pop3TestsPop3
    {

       static Servidor gmail = new Servidor()
        {
            Nombre = "gmail",
            HostSMTP = "smtp.gmail.com",
            HostPOP = "pop.gmail.com",
            PuertoPOP = 995,
            PuertoSMTP = 587,
            SSL = true

        };

        static Cuenta cuenta = new Cuenta()
        {
            DireccionId = "electronik.32@gmail.com",
            Contraseña = "proyecto3ro",
            CuentaId = "German Asmus",
            Servidor = gmail,
            //ServidorNombre = gmail.Nombre
        };

        static Buzon unBuzon = new Buzon();

        static Pop3 popClient = new Pop3(cuenta, unBuzon);

        [TestMethod()]
        public void DescargarCabecerasTest()
        {

            Task aTask = Task.Factory.StartNew(() => popClient.DescargarCabeceras(1));
            Task.WaitAll(aTask);
            unBuzon.BagChanged += RevisarBuzon;

        }
        public void RevisarBuzon()
        {
            Assert.IsNotNull(unBuzon.Cabeceras);
        }

        [TestMethod()]
        public void DescargarMensajeTest()
        {

            Task aTask = Task.Factory.StartNew(() => popClient.DescargarMensaje(1));
            Task.WaitAll(aTask);

            Assert.IsNotNull(unBuzon.Mensajes);
        }
    }
}
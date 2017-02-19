using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Entidades.Interfaces;
using Dominio.Entidades.Helper;
using System.Net.Mail;

namespace Dominio.Servicio.Tests
{
    [TestClass()]
    public class Pop3Tests
    {
        [TestMethod()]
        public void Pop3Test()
        {

        }

        [TestMethod()]
        public void EliminarTest()
        {

        }

        [TestMethod()]
        public void IniciarDescargaTest()
        {
            ICuenta aCuenta = new Cuenta("electronik.32@gmail.com");
            aCuenta.Contraseña = "proyecto3ro";
            IEnumerable<IMensaje> aDescarga = aCuenta.Descargar(1);
            Assert.IsNotNull(aDescarga);
        }

        [TestMethod()]
        public void IniciarDescargaTest1()
        {

        }

        [TestMethod()]
        public void DescargaTest()
        {

        }

        [TestMethod()]
        public void DescargaTest1()
        {

        }
    }
}
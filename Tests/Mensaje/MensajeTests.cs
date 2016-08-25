using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class MensajeTests
    {
        [TestMethod()]
        public void CambiarEstadoPersistencia()
        {
            var iCuenta = new CuentaExterna();

            var iMensaje = new MensajeIncompleto(iCuenta);

            var estadoInicial = iMensaje.EstadoPersistencia;
            iMensaje.CambiarEstadoPersistencia();
            Assert.AreNotEqual(estadoInicial, iMensaje.EstadoPersistencia);
        }

    }
}
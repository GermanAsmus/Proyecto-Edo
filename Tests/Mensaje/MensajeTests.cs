using CapaInterfaces.Modelo;
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
        static ICuenta iCuenta;
        static IMensaje iMensaje;

        [TestMethod()]
        public void CambiarEstadoPersistencia()
        {

            iCuenta = new CuentaExterna();
            iMensaje = new MensajeIncompleto(iCuenta);

            var estadoInicial = iMensaje.ObtenerEstadoPersistencia;
            iMensaje.CambiarEstadoPersistencia();
            Assert.AreNotEqual(estadoInicial, iMensaje.ObtenerEstadoPersistencia);
        }

        [TestMethod()]
        public void ObtenerEstrategiaPertenencia()
        {
            iCuenta = new CuentaExterna();
            iMensaje = new MensajeCompleto(iCuenta);

            var mensajeCompleto = (MensajeCompleto)iMensaje;
            var estrategiaPertenencia = mensajeCompleto.ObtenerPertenecia;
            Assert.AreEqual(estrategiaPertenencia, EstrategiaPertenencia.Externo.ToString());
        }

        [TestMethod()]
        public void ObtenerVisibilidad()
        {
            iCuenta = new CuentaExterna();
            iMensaje = new MensajeIncompleto(iCuenta);

            var mensajeCompleto = (MensajeIncompleto)iMensaje;
            var mensajeUsuario = (MensajeExterno)mensajeCompleto.Pertenencia;
            var visibilidad = mensajeUsuario.ObtenerVisibilidad();
            Assert.AreEqual(visibilidad, EstadoVisibilidad.No_Visto.ToString());
        }
    }
}
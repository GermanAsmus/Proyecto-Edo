using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class FachadaDominio : IFachadaDominio
    {
        private IFachadaPersistencia iFachadaPersistencia;

        public FachadaDominio(IFachadaPersistencia pFachadaPersistencia)
        {
            this.iFachadaPersistencia = pFachadaPersistencia;
        }

        public IEnumerable<IMensajeDTO> DescargarMensajes(ICuentaDeUsuarioDTO pCuenta, int pCantidad = 0)
        {
            try
            {
                ICuentaDeUsuario aCuenta = iFachadaPersistencia.ObtenerCuentaPorId(pCuenta.Id);
                return aCuenta.ObtenerMenasjes(pCantidad, true);
            }
            catch (Exception)
            {
                //log
                return null;
            }

        }

        public IMensajeDTO DescargarUnMensaje(ICuentaDeUsuarioDTO pCuenta, int pIdMensaje)
        {
            try
            {
                ICuentaDeUsuario aCuenta = iFachadaPersistencia.ObtenerCuentaPorId(pCuenta.Id);
                return aCuenta.ObtenerUnMensaje(pIdMensaje, true);
            }
            catch (Exception)
            {
                //log
                return null;
            }

        }

        public bool EliminarCuentaDeUsuario(ICuentaDeUsuarioDTO pCuenta)
        {
            try
            {
                ICuentaDeUsuario aCuenta = iFachadaPersistencia.ObtenerCuentaPorId(pCuenta.Id);
                this.iFachadaPersistencia.EliminarCuenta(aCuenta);
                return true;
            }
            catch (Exception)
            {
                //log
                return false;
            }

        }

        public bool EliminarMensaje(ICuentaDeUsuarioDTO pCuenta, IMensajeDTO pMensaje)
        {
            try
            {
                ICuentaDeUsuario aCuenta = iFachadaPersistencia.ObtenerCuentaPorId(pCuenta.Id);
                aCuenta.EliminarMensaje(pMensaje.Id);
                return true;
            }
            catch (Exception)
            {
                //log
                return false;
            }
        }

        public bool EnviarMensaje(ICuentaDeUsuarioDTO pCuenta, string pAsunto, ICollection<IDireccionCorreo> pDestinatario, string pContenido = "")
        {
            try
            {
                ICuentaDeUsuario aCuenta = iFachadaPersistencia.ObtenerCuentaPorId(pCuenta.Id);
                aCuenta.EnviarMensaje(pAsunto, pDestinatario, pContenido);
                return true;
            }
            catch (Exception)
            {
                //log
                return false;
            }
        }

        public bool NuevaCuentaDeUsuario(ICuentaDeUsuarioDTO pCuenta)
        {
            try
            {
                this.iFachadaPersistencia.AgregarCuenta(pCuenta as ICuentaDeUsuario);
                return true;
            }
            catch (Exception)
            {
                //log
                return false;
            }
        }

        public IEnumerable<ICuentaDeUsuarioDTO> ObtenerCuentas()
        {
            try
            {
                return this.iFachadaPersistencia.ObtenerCuentas();
            }
            catch (Exception)
            {
                //log
                return null;
            }
        }

        public IEnumerable<IMensajeDTO> ObtenerMensajes(ICuentaDeUsuarioDTO pCuenta)
        {
            try
            {
                ICuentaDeUsuario aCuenta = iFachadaPersistencia.ObtenerCuentaPorId(pCuenta.Id);
                return aCuenta.DireccionDeCorreo.MensajesRemitente;
            }
            catch (Exception)
            {
                //log
                return null;
            }
        }

        public ICuentaDeUsuarioDTO ObtenerUnaCuenta(int pIdCuenta)
        {
            try
            {
                return this.iFachadaPersistencia.ObtenerCuentaPorId(pIdCuenta);
            }
            catch (Exception)
            {
                //log
                return null;
            }
        }

        public IMensajeDTO ObtenerUnMensaje(ICuentaDeUsuarioDTO pCuenta, int pIdMensaje)
        {
            try
            {
                ICuentaDeUsuario aCuenta = iFachadaPersistencia.ObtenerCuentaPorId(pCuenta.Id);
                return aCuenta.ObtenerUnMensaje(pIdMensaje);
            }
            catch (Exception)
            {
                //log
                return null;
            }

        }
    }
}

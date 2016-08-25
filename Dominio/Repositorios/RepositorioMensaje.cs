using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaInterfaces.Dominio;
using CapaInterfaces;
using Utilidades.CriteriosDeBusqueda;
using CapaInterfaces.Modelo;

namespace Dominio.Repositorios
{
    public class RepositorioMensaje : RepositorioAbstracto<IMensaje>, IRepositorioUnico<IMensaje>
    {
        //private IRepositorioUnico<Adjunto> iRepositorioAdjunto;
        private IRepositorioUnico<IDireccionCorreo> iRepositorioDireccionDeCorreo;
        private IRepositorioUnico<ICuenta> iRepositorioCuenta;

        public RepositorioMensaje(IRepositorioUnico<IMensaje> pRepositorioInterno, /*IRepositorioUnico<Adjunto> pRepositorioAdjunto,*/ IRepositorioUnico<IDireccionCorreo> pRepositorioDireccionDeCorreo, IRepositorioUnico<ICuenta> pRepositorioCuenta) : base(pRepositorioInterno)
        {
            //this.iRepositorioAdjunto = pRepositorioAdjunto;
            this.iRepositorioDireccionDeCorreo = pRepositorioDireccionDeCorreo;
            this.iRepositorioCuenta = pRepositorioCuenta;
        }

        public int Agregar(IMensaje pEntidad)
        {
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad));

            if (pEntidad.Cuenta == null)
                throw new ArgumentNullException(nameof(pEntidad.Cuenta));

            //verifica que los string no sean nulos o vacios
            if (string.IsNullOrEmpty(pEntidad.Asunto))
                throw new NullReferenceException("El asunto del mensaje no puede ser vacío o nulo");

            List<IDireccionCorreo> destinatariosValidos = new List<IDireccionCorreo>();
            var destinatarios = pEntidad.Destinatario.GetEnumerator();

            IDireccionCorreo iDireccion = null;
            while (destinatarios.MoveNext())
            {
                iDireccion = this.iRepositorioDireccionDeCorreo.Obtener(d => BuscarDireccionDeCorreo.BuscarPorDireccion(d, destinatarios.Current.DireccionDeCorreo));
                if (iDireccion != null)
                    destinatariosValidos.Add(destinatarios.Current);
            }
            pEntidad.Destinatario = destinatariosValidos;
                    
            ICuentaUsuario iCuenta = (ICuentaUsuario)this.iRepositorioCuenta.Obtener(x => BuscarCuenta.BuscarPorId(x, pEntidad.Cuenta.Id));
            if (iCuenta == null)
                throw new NullReferenceException(nameof(iCuenta));

            iCuenta.Mensajes.Add(pEntidad);
            //Se completa la propiedad requerida del entidadHija, respectiva al id de la cuenta.
            pEntidad.CuentaId = iCuenta.Id;
            //Se actualiza la cuenta, que mantiene una colección de mensajes.
            return iRepositorioCuenta.Editar();
        }
    }
}

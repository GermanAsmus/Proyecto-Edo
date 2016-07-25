using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDependencia.Dominio;
using ControlDependencia;
using Utilidades.CriteriosDeBusqueda;

namespace Dominio
{
    public class RepositorioMensaje : RepositorioAbstracto<Mensaje>, IRepositorioUnico<Mensaje>
    {
        //private IRepositorioUnico<Adjunto> iRepositorioAdjunto;
        private IRepositorioUnico<DireccionCorreo> iRepositorioDireccionDeCorreo;
        private IRepositorioUnico<Cuenta> iRepositorioCuenta;

        public RepositorioMensaje(IRepositorioUnico<Mensaje> pRepositorioInterno, /*IRepositorioUnico<Adjunto> pRepositorioAdjunto,*/ IRepositorioUnico<DireccionCorreo> pRepositorioDireccionDeCorreo, IRepositorioUnico<Cuenta> pRepositorioCuenta) : base(pRepositorioInterno)
        {
            //this.iRepositorioAdjunto = pRepositorioAdjunto;
            this.iRepositorioDireccionDeCorreo = pRepositorioDireccionDeCorreo;
            this.iRepositorioCuenta = pRepositorioCuenta;
        }

        public int Agregar(Mensaje pEntidad)
        {
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad));

            if (pEntidad.Cuenta == null)
                throw new ArgumentNullException(nameof(pEntidad.Cuenta));

            //verifica que los string no sean nulos o vacios
            if (string.IsNullOrEmpty(pEntidad.Asunto))
                throw new NullReferenceException("El asunto del mensaje no puede ser vacío o nulo");

            List<DireccionCorreo> destinatariosValidos = new List<DireccionCorreo>();
            var destinatarios = pEntidad.Destinatario.GetEnumerator();

            DireccionCorreo iDireccion = null;
            while (destinatarios.MoveNext())
            {
                iDireccion = this.iRepositorioDireccionDeCorreo.Obtener(d => BuscarDireccionDeCorreo.BuscarPorDireccion(d, destinatarios.Current.DireccionDeCorreo));
                if (iDireccion != null)
                    destinatariosValidos.Add(destinatarios.Current);
            }
            pEntidad.Destinatario = destinatariosValidos;
                    
            Cuenta iCuenta = this.iRepositorioCuenta.Obtener(x => BuscarCuenta.BuscarPorId(x, pEntidad.Cuenta.Id));
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

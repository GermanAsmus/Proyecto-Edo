using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaInterfaces.Dominio;
using CapaInterfaces;
using Utilidades.CriteriosDeBusqueda;
using CapaInterfaces.Modelo;
using System.Data.Entity;

namespace Persistencia
{
    public class RepositorioMensaje : Repositorio<IMensajeDTO>
    {
        private IRepositorioCompleto<ICuentaDTO> iRepositorioCuenta;

        public RepositorioMensaje(IRepositorioCompleto<ICuentaDTO> pRepositorioCuenta, IDbSet<IMensajeDTO> pDbSet) : base(pDbSet)
        {
            this.iRepositorioCuenta = pRepositorioCuenta;
        }

        public override void Agregar(IMensajeDTO pEntidad)
        {
            #region programacion defensiva
            if (pEntidad == null)
                throw new ArgumentNullException(nameof(pEntidad));

            if (pEntidad.Cuenta == null)
                throw new ArgumentNullException(nameof(pEntidad.Cuenta));

            //verifica que los string no sean nulos o vacios
            if (string.IsNullOrEmpty(pEntidad.Asunto))
                throw new NullReferenceException("El asunto del mensaje no puede ser vacío o nulo");
            #endregion

            //crea una lista donde se guardaran los destinatarios que sean validos
            List<ICuentaDTO> destinatariosValidos = new List<ICuentaDTO>();
            //obtiene todos los destinatarios que tiene el mensaje
            var destinatarios = pEntidad.Destinatario.GetEnumerator();

            ICuentaDTO iDireccion = null;
            while (destinatarios.MoveNext())
            {
                //obtiene los destinatarios que existan en la base de datos
                iDireccion = this.iRepositorioCuenta.Obtener(d => BuscarCuenta.BuscarPorId(d, destinatarios.Current.DireccionCorreo.Id));
                //verifica que el destino no sea nulo
                if (iDireccion != null)
                    destinatariosValidos.Add(destinatarios.Current);
            }
            pEntidad.Destinatario = destinatariosValidos;

            //obtiene la cuenta del usuario
            ICuentaUsuarioDTO iCuenta = (ICuentaUsuarioDTO)this.iRepositorioCuenta.Obtener(x => BuscarCuenta.BuscarPorId(x, pEntidad.Cuenta.Id));

            if (iCuenta == null)
                throw new NullReferenceException(nameof(iCuenta));

            iCuenta.Mensajes.Add(pEntidad);
            //Se completa la propiedad requerida del entidadHija, respectiva al id de la cuenta.
            pEntidad.CuentaId = iCuenta.Id;
            //Se actualiza la cuenta, que mantiene una colección de mensajes.
        }
    }
}

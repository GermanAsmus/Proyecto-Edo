using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EdoUI.Entidades.DTO;

namespace Persistencia.Repositorios
{
    public class RepositorioMensaje : Repositorio<IMensaje>, IRepositorioMensaje
    {
        private IRepositorioCuenta iRepositorioCuenta;

        public RepositorioMensaje(IRepositorioCuenta pRepositorioCuenta, IDbSet<IMensaje> pDbSet) : base(pDbSet)
        {
            this.iRepositorioCuenta = pRepositorioCuenta;
        }

        public override void Agregar(IMensaje pEntidad)
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
            List<ICuenta> destinatariosValidos = new List<ICuenta>();
            //obtiene todos los destinatarios que tiene el mensaje
            var destinatarios = pEntidad.Destinatario.GetEnumerator();

            ICuenta iDireccion = null;
            while (destinatarios.MoveNext())
            {
                //obtiene los destinatarios que existan en la base de datos
                iDireccion = this.iRepositorioCuenta.Obtener(destinatarios.Current.DireccionCorreo.Id);
                //verifica que el destino no sea nulo
                if (iDireccion != null)
                    destinatariosValidos.Add(destinatarios.Current);
            }
            pEntidad.Destinatario = destinatariosValidos;

            //obtiene la cuenta del usuario
            ICuenta iCuenta = (ICuenta)this.iRepositorioCuenta.Obtener(pEntidad.Cuenta.Id);

            if (iCuenta == null)
                throw new NullReferenceException(nameof(iCuenta));

            iCuenta.Mensajes.Add(pEntidad);
            //Se completa la propiedad requerida del entidadHija, respectiva al id de la cuenta.
            pEntidad.CuentaId = iCuenta.Id;
            //Se actualiza la cuenta, que mantiene una colección de mensajes.
        }

        public IMensaje Obtener(int? pId)
        {
            if (pId.HasValue)
                return base.Obtener(mensaje => mensaje.Id == pId);
            else
                return base.Obtener();
        }

        public IMensaje Obtener(string pAsunto = null)
        {
            if (string.IsNullOrEmpty(pAsunto))
                return base.Obtener(mensaje => mensaje.Asunto == pAsunto);
            else
                return base.Obtener();
        }

        public IEnumerable<IMensaje> ObtenerSegun(int? pId)
        {
            if (pId.HasValue)
                return base.ObtenerSegun(mensaje => mensaje.Id == pId);
            else
                return base.ObtenerSegun();
        }

        public IEnumerable<IMensaje> ObtenerSegun(string Asunto = null)
        {
            if (string.IsNullOrEmpty(Asunto))
                return base.ObtenerSegun(mensaje => mensaje.Asunto == Asunto);
            else
                return base.ObtenerSegun();
        }
    }
}

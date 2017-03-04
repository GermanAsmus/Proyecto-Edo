using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dominio.Entidades.Interfaces;
using Dominio.Entidades;

namespace Persistencia.Repositorios
{
    public class RepositorioMensaje : Repositorio<IMensaje>, IRepositorioMensaje
    {
        private IRepositorioDireccion iRepositorioDireccion;

        public RepositorioMensaje(IRepositorioDireccion pRepositorioDireccion, IDbSet<IMensaje> pDbSet) : base(pDbSet)
        {
            this.iRepositorioDireccion = pRepositorioDireccion;
        }

        public override void Agregar(IMensaje pEntidad)
        {
            #region programacion defensiva
            if (pEntidad == null || pEntidad.Remitente == null)
                throw new ArgumentNullException(nameof(pEntidad));
            #endregion

            //agrega aquellas direcciones que no existen en la base de datos
            pEntidad.Destinatario.ToList().ForEach(d=> {
                if (this.iRepositorioDireccion.ObtenerUno(d.DireccionDeCorreo) == null)
                    this.iRepositorioDireccion.Agregar(new DireccionCorreo(d.DireccionDeCorreo));
            });

            //agrega la direccion del remitente si no existe en la base de datos
            IDireccionCorreo aRemitente = this.iRepositorioDireccion.ObtenerUno(pEntidad.Remitente.DireccionDeCorreo);
            if (aRemitente == null)
            {
                this.iRepositorioDireccion.Agregar(new DireccionCorreo(pEntidad.Remitente.DireccionDeCorreo));
                aRemitente = this.iRepositorioDireccion.ObtenerUno(pEntidad.Remitente.DireccionDeCorreo);
            }

            base.AgregarEntidad(pEntidad);
            //Se completa la propiedad requerida del entidadHija, respectiva al id de la cuenta.
            pEntidad.RemitenteId = aRemitente.Id;
            //Se actualiza la cuenta, que mantiene una colección de mensajes.
        }

        public IMensaje ObtenerUno(int? pId)
        {
            if (pId.HasValue)
                return base.ObtenerUno(mensaje => mensaje.Id == pId);
            else
                return base.ObtenerUno();
        }

        public IMensaje ObtenerUno(string pAsunto = null)
        {
            if (string.IsNullOrEmpty(pAsunto))
                return base.ObtenerUno(mensaje => mensaje.Asunto == pAsunto);
            else
                return base.ObtenerUno();
        }

        public IEnumerable<IMensaje> ObtenerTodos(int? pId)
        {
            if (pId.HasValue)
                return base.ObtenerTodos(mensaje => mensaje.Id == pId);
            else
                return base.ObtenerTodos();
        }

        public IEnumerable<IMensaje> ObtenerTodos(string Asunto = null)
        {
            if (string.IsNullOrEmpty(Asunto))
                return base.ObtenerTodos(mensaje => mensaje.Asunto == Asunto);
            else
                return base.ObtenerTodos();
        }
    }
}

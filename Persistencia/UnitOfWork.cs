using System;
using System.Collections.Generic;
using CapaInterfaces;
using CapaInterfaces.Persistencia;
using System.Linq;
using Modelo;
using EdoUI;
using CapaInterfaces.Modelo;
using System.Data.Entity;
//using UnityDI;

namespace Persistencia
{
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// El contexto en el que se ejecuta la aplicación.
        /// </summary>
        internal IContext iContext;
        /// <summary>
        /// Colección de repositorios, mantendrán los mensajes CRUD correspondientes.
        /// </summary>
        internal ICollection<IRepositorioRaiz> iRepositorios;

        public UnitOfWork(IContext pContext)
        {
            this.iContext = pContext;

            ///Se instancian los repositorios sin necesidad de forma contreta y directamente.
            ///Cada instancia pone al UoW en dependencia como observador, 
            ///cuando se realize algún cámbio en el contexto, 
            ///el repositorio correspondiente disparará la acción para avisarle al UoW,
            ///quien actualizará el contexto.

            #region Instaciar repositorio cuenta

            IRepositorioCompleto<ICuentaDTO> rCuenta = new Repositorio<ICuentaDTO>((this.iContext as DbContext).Set<ICuentaDTO>());
            (rCuenta as Repositorio<ICuentaDTO>).Actualizar += Actualizar;

            this.iRepositorios.Add(rCuenta);

            #endregion

            #region Instanciar repositorio mensaje

            IRepositorioCompleto<IMensajeDTO> rMensaje = new Repositorio<IMensajeDTO>((this.iContext as DbContext).Set<IMensajeDTO>());
            (rMensaje as Repositorio<IMensajeDTO>).Actualizar += Actualizar;

            this.iRepositorios.Add(rMensaje);

            #endregion

            #region Instanciar repositorio adjunto

            IRepositorioCompleto<IAdjuntoDTO> rAdjunto = new Repositorio<IAdjuntoDTO>((this.iContext as DbContext).Set<IAdjuntoDTO>());
            (rAdjunto as Repositorio<IAdjuntoDTO>).Actualizar += Actualizar;

            this.iRepositorios.Add(rAdjunto);

            #endregion

            #region Instanciar repositorio direccion

            IRepositorioCompleto<IDireccionCorreoDTO> rDireccion = new Repositorio<IDireccionCorreoDTO>((this.iContext as DbContext).Set<IDireccionCorreoDTO>());
            (rDireccion as Repositorio<IDireccionCorreoDTO>).Actualizar += Actualizar;

            this.iRepositorios.Add(rDireccion);

            #endregion

        }

        /// <summary>
        /// Método de acción que responde a los cambios de los repositorios que mantiene la clase. 
        /// </summary>
        private void Actualizar()
        {
            this.Commit();
        }
        /// <summary>
        /// Obtiene el repositorio correspondiente al tipo referenciado.
        /// El repositorio debe pertenecer a la colección que mantiene la clase. 
        /// </summary>
        /// <typeparam name="T">Tipo de entidad modelo que pertenece a un repositorio particular</typeparam>
        /// <returns>Repositorio correspondiente al tipo referenciado</returns>
        public IRepositorioCompleto<T> ObtenerRepositorio<T>() where T : class, IEntidadModelo
        {
            return (IRepositorioCompleto<T>)this.iRepositorios.FirstOrDefault(x => x.GetType().GetGenericTypeDefinition() == typeof(T));
        }

        public int Commit()
        {
            return iContext.Commit();
        }
        public void Dispose()
        {
            try
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("El garbage collector no puede finalizar con el finalizar con la instancia del UnitOfWork porque ya es nula", ex);
            }
        }
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (iContext != null)
                {
                    iContext.Dispose();
                    iContext = null;
                }
            }

        }
    }
}

using Modelo;
using ControlDependencia;
using Utilidades;
using System;
using ControlDependencia.Dominio;
using Utilidades.CriteriosDeBusqueda;

namespace Dominio
{
    /// <summary>
    /// Implementación concreta del RepositorioAbstracto, definida para la entidad de modelo Adjunto.
    /// Implementa una la interfaz de agregación compleja, en donde el adjunto es una entidad dependiente del mensaje.
    /// </summary>
    public class RepositorioAdjunto : RepositorioAbstracto<Adjunto>,IEstrategiaAgregarComplejo<Adjunto, Mensaje>
    {
        public RepositorioAdjunto(IRepositorio<Adjunto> iRepositorio, IGestorRespositorios pGestor) : base(iRepositorio, pGestor) { }
        /// <summary>
        /// Agrega al adjunto a la colección de adjunto que mantiene el mensaje.
        /// </summary>
        /// <param name="pHijo">Entidad mdjunto</param>
        /// <param name="pPadre">Entidad mensaje</param>
        /// <returns>0 si no se pudo completar la operación, sino se realizó correctamente</returns>
        public int Agregar(Adjunto pHijo, Mensaje pPadre)
        {

            //Se previene que pHijo y pPadre no sean nulos

            if (pHijo == null)
                throw new ArgumentNullException(nameof(pHijo));

            if (pPadre == null)
                throw new ArgumentNullException(nameof(pPadre));

            //Utiliza un criterio de busqueda por id para obtener la entidad del sistema.
            Adjunto iAdjunto = Obtener(x => BuscarAdjunto.BuscarPorId(x,pHijo.Id));
            if (iAdjunto == null)
                throw new NullReferenceException(nameof(iAdjunto));

            //Obtiene el repositorio de mensaje para poder concretar la operación.
            IRepositorio<Mensaje> RepositorioMensaje = this.GestorRepositorios.ObtenerRepositorio<Mensaje>();
           
            Mensaje iMensaje = RepositorioMensaje.Obtener(x => BuscarMensaje.BuscarPorId(x,pPadre.Id));
            if (iMensaje == null)
                throw new NullReferenceException(nameof(iMensaje));
            //Agrega el adjunto a la colección de Adjuntos del mensaje.
            iMensaje.Adjuntos.Add(iAdjunto);
            //Confirma la edición de la entidad mensaje.
            return RepositorioMensaje.Editar(pPadre);
        }
    }
}

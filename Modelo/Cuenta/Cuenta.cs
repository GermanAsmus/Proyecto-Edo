using CapaInterfaces;
using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Linq.Expressions;
using System.Linq;

namespace Modelo
{
    /// <summary>
    /// Entidad abstracta que modela una cuenta de correo.
    /// </summary>
    public abstract class Cuenta : ICuenta
    {
        #region Propiedades
        //Identificador único de la cuenta.
        public int Id { get; set; }

        //Identificador de la direccion de correo de la cuenta
        public int DireccionId { get; set; }

        public IDireccionCorreo DireccionCorreo { get; set; }

        //Colección de mensjes que se relacionan con la cuenta.
        public virtual ICollection<IMensaje> Mensajes { get; set; }

        public IServidor Servidor { get; set; }
        #endregion

        /// <summary>
        /// Atributo responsable de realizar la cuenta cuando se instancie la clase.
        /// </summary>
        protected ICuentaFactory iCuentaFactory;
        /// <summary>
        /// Al realizar la cuenta se instancia el servidor.
        /// El servidor se obtiene de la misma direccion de correo (ej: correo@gmail.com --> host = gmail)
        /// </summary>
        protected virtual void RealizarCuenta()
        {
            this.Servidor = this.iCuentaFactory.AgregarServidor(Modelo.DireccionCorreo.ObtenerHost(this.DireccionCorreo));
        }

        /// <summary>
        /// Constructor de la clase cuenta.
        /// </summary>
        /// <param name="pCuentaFactory">Clase responsable de realizar a la cuenta</param>
        public Cuenta(ICuentaFactory pCuentaFactory, string pDireccion)
        {

            if (string.IsNullOrEmpty(pDireccion))
                throw new ArgumentNullException(nameof(pDireccion));

            this.DireccionCorreo = new DireccionCorreo(pDireccion);

            this.iCuentaFactory = pCuentaFactory;
            this.RealizarCuenta();
            //se inicializa la lista de mensajes, esto facilita el manejo con el EF.
            Mensajes = new List<IMensaje>();
        }


        #region Metodos de getion de mensajes de la cuenta
        //¿Está bien que cuenta tenga la responsabilidad de agregar nuevos mensajes, eliminar...?
        //¿Pordría comunicarse la clase con el repositorio de mensajes para actualizar la bd?
        //¿Cómo se podría hacer?, mi idea era hacerlo mediante el patron observer, o de algún modo similar para que se actualice la
        //lista de mensajes.

        public void AgregarNuevoMensaje(IMensaje pEntidad)
        {
            this.Mensajes.Add(pEntidad);
        }
        public void EliminarMensaje(IMensaje pEntidad)
        {
            this.Mensajes.Remove(pEntidad);
        }
        public IEnumerable<IMensaje> ObtenerSegun(Expression<Func<IMensaje, bool>> pCriterio)
        {
            return this.Mensajes.AsQueryable().Where(pCriterio);
        }
        public IMensaje Obtener(Expression<Func<IMensaje, bool>> pCriterio)
        {
            return this.Mensajes.AsQueryable().FirstOrDefault(pCriterio);
        }
        #endregion

    }
}

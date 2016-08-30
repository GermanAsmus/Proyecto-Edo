using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Modelo
{
    /// <summary>
    /// Modela un menaje (correo), como una entidad de base y no concluyente.
    /// Sus clases derivadas concretan el mensaje (agregando significado y siendo más responsables).
    /// </summary>
    public abstract class Mensaje : IMensaje
    {
        //protected RepositorioModelo<IDireccionCorreo> iRepositorioDireccion;

        #region Propiedades
        //Identificador único del mensaje
        public int Id { get; set; }
        //Asunto del mensaje.
        public string Asunto { get; set; }
        //Identificador de la cuenta asociada.
        public int CuentaId { get; set; }
        //Entidad de la cuenta asociada.
        public ICuenta Cuenta { get; set; }
        // Colección de direcciones de correo como direcciones destinatarios.
        public virtual ICollection<IDireccionCorreo> Destinatario { get; set; }

        #endregion
        /// <summary>
        /// Estado de persistencia del mensaje. (Guardado/No_Guardado).
        /// </summary>
        private EstadoPersistencia iEstadoPersistencia;
        /// <summary>
        /// Constructor de la clase.
        /// El estado de persistencia por defecto es "No_Guardado".
        /// </summary>
        public Mensaje()
        {
            Destinatario = new List<IDireccionCorreo>();
            this.iEstadoPersistencia = EstadoPersistencia.No_Guardado;
        }
        /// <summary>
        /// Cambia el estado de persistencia del mensaje.
        /// (Guardado/No_Guardado).
        /// </summary>
        public void CambiarEstadoPersistencia()
        {
            if (this.iEstadoPersistencia != EstadoPersistencia.Guardado)
                this.iEstadoPersistencia = EstadoPersistencia.Guardado;
            else
                this.iEstadoPersistencia = EstadoPersistencia.No_Guardado;

        }
        /// <summary>
        /// Obtiene el estado de persistencia del mensaje.
        /// (Guardado/No_Guardado).
        /// </summary>
        public string ObtenerEstadoPersistencia
        {
            get { return this.iEstadoPersistencia.ToString(); }
        }


        #region Metodos

        public IEnumerable<IDireccionCorreo> ObtenerSegun(Expression<Func<IDireccionCorreo, bool>> pCriterio)
        {
            return this.Destinatario.AsQueryable().Where(pCriterio);
        }
        public IDireccionCorreo Obtener(Expression<Func<IDireccionCorreo, bool>> pCriterio)
        {
            return this.Destinatario.AsQueryable().FirstOrDefault(pCriterio);
        }

        public void AgregarNuevoDestinatario(IDireccionCorreo pDireccionCorreo)
        {
            this.Destinatario.Add(pDireccionCorreo);
        }
        public void EliminarDestinatario(IDireccionCorreo pDireccionCorreo)
        {
            this.Destinatario.Remove(pDireccionCorreo);
        }

        #endregion




        //IDEA: metodo estático que permita devolver todo el mensaje como un texto plano.

        ////Identificador de la dirección de correo asociada al mensaje, como dirección remitente.
        //public int DireccionId { get; set; }
        ////Entidad de la dirección de correo remitente.
        //public DireccionCorreo DireccionCorreo { get; set; }
    }
}

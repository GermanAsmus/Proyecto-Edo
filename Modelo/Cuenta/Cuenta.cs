using CapaInterfaces;
using CapaInterfaces.Modelo;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Linq.Expressions;

namespace Modelo
{
    /// <summary>
    /// Entidad Cuenta, modela una cuenta de correo.
    /// </summary>
    public abstract class Cuenta : ICuenta
    {
        //Identificador único de la cuenta.
        public int Id { get; set; }

        //Identificador de la direccion de correo de la cuenta
        public int DireccionId { get; set; }

        public IDireccionCorreo DireccionCorreo { get; set; }

        //Colección de mensjes que se relacionan con la cuenta.
        public virtual ICollection<IMensaje> Mensajes { get; set; }

        //Constructor de la clase
        public Cuenta()
        {
            Mensajes = new List<IMensaje>();
        }

        public void NuevoMensaje(IMensaje pMensaje)
        {
            if (pMensaje == null)
                throw new ArgumentNullException(string.Format("El parámetro {0} no puede ser nulo", nameof(pMensaje)));
            this.Mensajes.Add(pMensaje);
        }

        //Preguntar si:
        //¿Implementar Irepositorio<Mensaje> en cuenta está bien?
        //La idea es que cuenta tenga la responsabilidad de agregar nuevos mensajes, eliminar...
        //De no poder implemntarse así, los mensajes me parecen que están bien,
        //¿Pordría comunicarse la clase con el repositorio de mensajes para actualizar la bd?
        //¿Cómo?, mi idea era hacerlo mediante el patron observer, o algo así para que se actualice la
        //lista de mensajes.

        public void AgregarNuevoMensaje(IMensaje pEntidad) { }
        public void EliminarMensaje(IMensaje pEntidad) { }
        public abstract IEnumerable<IMensaje> ObtenerTodos();
        public abstract IEnumerable<IMensaje> ObtenerSegun(Expression<Func<IMensaje, bool>> pCriterio);
        public abstract IMensaje Obtener(Expression<Func<IMensaje, bool>> pCriterio);
    }
}

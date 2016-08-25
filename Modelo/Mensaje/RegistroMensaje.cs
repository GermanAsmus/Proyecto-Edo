using System;
using System.Collections.Generic;

namespace Modelo
{
    public class RegistroMensaje : IRegistroMensaje
    {
        private ICollection<DateTime> RegistrosViejos { get; set; }
        public DateTime Fecha { get; private set; }

        //Se inicializa el registro con la fecha actual
        public RegistroMensaje()
        {
            this.Fecha = DateTime.Now;
        }
        //Se inicializa el registro con una fecha especificada
        public RegistroMensaje(DateTime pFecha)
        {
            this.Fecha = pFecha;
        }
        public RegistroMensaje(string pPharseFecha)
        {

            if (pPharseFecha == null)
                throw new ArgumentNullException(string.Format("El valor {0} no puede ser nulo", nameof(pPharseFecha)));

            try
            {
                this.Fecha = DateTime.Parse(pPharseFecha);

            }
            catch (FormatException ex)
            {

                throw new ApplicationException(string.Format("El valor {0}, referido a la fehca que se introdujo no poseía el formato esperado", nameof(pPharseFecha)), ex);
            }
        } 
        public DateTime ModificarRegistro(DateTime pNuevaFecha)
        {
            if (pNuevaFecha == null)
                throw new ArgumentNullException(string.Format("El valor {0} no puede ser nulo",nameof(pNuevaFecha)));
            
            //se guarda la fecha anterior, para mantener el registro de los cambios
            this.RegistrosViejos.Add(this.Fecha);

            this.Fecha = pNuevaFecha;

            return this.Fecha;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Modelo
{
    public class RegistroMensaje<T> : IRegistroMensaje<T> where T: struct, IConvertible
    {
        public DateTime Fecha { get; }
        public T Registro { get; }


        //Se inicializa el registro con la fecha actual
        public RegistroMensaje(T pRegistro)
        {
            this.Fecha = DateTime.Now;
            this.Registro = pRegistro;
        }
        //Se inicializa el registro con una fecha especificada
        public RegistroMensaje(DateTime pFecha, T pRegistro)
        {
            this.Fecha = pFecha;
            this.Registro = pRegistro;
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

        public bool NoEsNulo()
        {
            return this.Fecha != null;
        }
    }
}

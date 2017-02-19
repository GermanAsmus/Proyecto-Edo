using Servicio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public abstract class ProtocoloAbstract
    {
        protected string iDireccion;
        protected string iContraseña;
        protected string iHost;
        protected int iPuerto;
        protected bool iSSL;


        public ProtocoloAbstract(string pDireccion, string pContraseña, string pHost, int? pPuerto, bool pSSL)
        {
            if (string.IsNullOrEmpty(pDireccion) && string.IsNullOrEmpty(pHost))
                throw new ProtocolException("Los campos direccion y el host no pueden ser vacíos");
            if (!pPuerto.HasValue)
                throw new ProtocolException("El puerto no puede estár vacío, problemas en el puerto del servidor");

            this.iDireccion = pDireccion;
            this.iContraseña = pContraseña;
            this.iHost = pHost;
            this.iPuerto = pPuerto.Value;
            this.iSSL = pSSL;


        }
    }
}

using System;
using CapaInterfaces.Modelo;

namespace Modelo
{
    //Si CuentaFactory puede resolver todo entonces hay que eliminar esta clase
    public class CuentaExternaFactory : CuentaFactory
    {
        public CuentaExternaFactory(string pNombre) : base(pNombre)
        {
        }
    }
}
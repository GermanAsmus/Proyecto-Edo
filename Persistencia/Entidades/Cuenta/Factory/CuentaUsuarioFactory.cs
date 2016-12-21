using System;
using CapaInterfaces.Modelo;
using System.Collections.Generic;

namespace Modelo
{
    //Si CuentaFactory puede resolver todo entonces hay que eliminar esta clase
    public class CuentaUsuarioFactory : CuentaFactory
    {
        public CuentaUsuarioFactory(string pNombre) : base(pNombre)
        {

        }
    }
}
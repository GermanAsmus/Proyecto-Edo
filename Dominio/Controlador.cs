using ControlDependencia;

using Modelo;
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Controlador : IControlador
    {
        public IGestor iGestor { get; }
        public IConexion iServicio { get; }

        public Controlador(IGestor pGestor, IConexion pConexion)
        {
            // resolver con inyección de dependencia
            iGestor = pGestor;//new Gestor(pUnitOfWork);
            iServicio = pConexion;
        }
    }
}

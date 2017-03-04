using Dominio;
using System;

namespace DataLayer
{
    internal interface IUnitOfWork
    {
        IRepositorio<ICuentaDeUsuario> RepositorioCuenta { get; }
    }
}
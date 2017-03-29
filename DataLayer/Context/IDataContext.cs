using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace DataLayer
{
    internal interface IDataContext : IDisposable
    {
        EdoDatabaseContext Context { get; }
        int Commit();
    }
}
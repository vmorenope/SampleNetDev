using System;
using System.Collections.Generic;

namespace Anita.Repositories
{
    public interface IRepository : IDisposable
    {
        int Insert<T>(T entity) where T : class;
        bool Update<T>(T entity) where T : class;
        bool Delete<T>(T entity) where T : class;
        IEnumerable<T> GetList<T>() where T : class;
        T GetById<T>(int id) where T : class;
    }
}

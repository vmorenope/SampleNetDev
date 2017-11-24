using System.Collections.Generic;

namespace Cibertec.Repositories
{
    public interface IRepository
    {
        int Isert<T>(T entity) where T : class;
        bool Update<T>(T entity) where T : class;
        bool Dateted<T>(T entity) where T : class;
        IEnumerable<T> GetList<T>() where T : class;
        T GetById<T>(int id) where T : class;
    }
}

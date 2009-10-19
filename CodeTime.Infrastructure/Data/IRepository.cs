using System;
using System.Linq;

namespace CodeTime.Infrastructure.Data
{
    public interface IRepository<T> : IDisposable
    {        
        IQueryable<T> GetAll();
        void Save(T entity);
    }
}
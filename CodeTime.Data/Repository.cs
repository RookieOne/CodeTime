using System.Linq;
using CodeTime.Infrastructure.Data;
using NHibernate;
using NHibernate.Linq;

namespace CodeTime.Data
{
    public class Repository<T> : IRepository<T>
    {
        readonly ISession _Session;
        ITransaction _Transaction;

        public Repository(INHibConfig config)
        {
            _Session = config.GetSession();            
        }

        public IQueryable<T> GetAll()
        {
            return from entity in _Session.Linq<T>()
                   select entity;
        }

        public void Save(T entity)
        {
            _Transaction = _Session.BeginTransaction();
            _Session.Save(entity);
            //_Session.SaveOrUpdate(entity);
            _Transaction.Commit();
        }

        public void Dispose()
        {
            _Session.Dispose();
            _Transaction.Dispose();
        }
    }
}
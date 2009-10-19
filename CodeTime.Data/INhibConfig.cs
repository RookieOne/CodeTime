using NHibernate;

namespace CodeTime.Data
{
    public interface INHibConfig
    {
        string DatabaseName { get; }
        string Server { get; }
        ISession GetSession();
    }
}
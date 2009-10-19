using System.Collections.Generic;
using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace CodeTime.Data
{
    public class NHibConfig : INHibConfig
    {
        readonly List<Assembly> _mappingAssemblies;
        ISessionFactory _factory;

        public string DatabaseName { get; private set; }
        public string Server { get; private set; }

        NHibConfig()
        {
            _mappingAssemblies = new List<Assembly>();
        }

        public static NHibConfig Create()
        {
            return new NHibConfig();
        }

        public ISession GetSession()
        {
            return _factory.OpenSession();
        }

        public NHibConfig ServerIs(string server)
        {
            Server = server;
            return this;
        }

        public NHibConfig DatabaseNameIs(string databaseName)
        {
            DatabaseName = databaseName;
            return this;
        }

        public NHibConfig RegisterMappings(Assembly assembly)
        {
            _mappingAssemblies.Add(assembly);

            return this;
        }

        public NHibConfig Build()
        {
            var sqlConfig = MsSqlConfiguration.MsSql2005
                .ConnectionString(c => c.Server(Server)
                                           .Database(DatabaseName)
                                           .TrustedConnection());

            var config = Fluently.Configure()
                .Database(sqlConfig);

            foreach (var assembly in _mappingAssemblies)
            {
                config.Mappings(m => m.FluentMappings.AddFromAssembly(assembly));
            }

            _factory = config.BuildSessionFactory();

            return this;
        }
    }
}
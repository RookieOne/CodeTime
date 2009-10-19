using System.Reflection;
using Castle.Windsor;
using CodeTime.Data;
using CodeTime.Domain.Data.Projects;
using CodeTime.Infrastructure.Data;
using OpenRasta.DI;
using OpenRasta.DI.Windsor;

namespace CodeTime.OpenRasta.Service.DependencyInjection
{
    public class WindsorResolverFactory : IDependencyResolverAccessor
    {
        public IDependencyResolver Resolver
        {
            get { return _resolver; }
        }

        static IDependencyResolver _resolver;

        public WindsorResolverFactory()
        {
            if (_resolver == null)
            {
                var container = new WindsorContainer();

                var config = NHibConfig.Create()
                    .ServerIs("localhost")
                    .DatabaseNameIs("CodeTime")
                    .RegisterMappings(Assembly.GetAssembly(typeof (ProjectMap)))
                    .Build();

                container.Kernel.AddComponentInstance("NHibConfig", typeof (INHibConfig), typeof (NHibConfig), config);

                container.AddComponent("Repositories", typeof (IRepository<>), typeof (Repository<>));

                _resolver = new WindsorDependencyResolver(container);
            }
        }
    }
}
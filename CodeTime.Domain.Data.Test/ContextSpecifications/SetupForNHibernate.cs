using System.Reflection;
using CodeTime.Data;
using CodeTime.Domain.Data.Projects;
using CodeTime.Domain.Projects;
using CodeTime.Test;

namespace CodeTime.Domain.Data.Test.ContextSpecifications
{
    public class SetupForNHibernate : ContextSpecification
    {
        protected INHibConfig _Config;

        protected override void Given()
        {
            base.Given();

            _Config = NHibConfig.Create()
                .ServerIs("localhost")
                .DatabaseNameIs("CodeTime")
                .RegisterMappings(Assembly.GetAssembly(typeof(ProjectMap)))
                .Build();
        }
    }
}
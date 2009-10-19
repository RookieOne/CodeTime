using CodeTime.Data;
using CodeTime.Domain.Data.Test.ContextSpecifications;
using CodeTime.Domain.Projects;

namespace CodeTime.Domain.Data.Test.Projects
{
    public class ProjectRepository : SetupForNHibernate
    {
        protected Repository<Project> _Repository;

        protected override void Given()
        {
            base.Given();
            
            _Repository = new Repository<Project>(_Config);
        }
    }
}
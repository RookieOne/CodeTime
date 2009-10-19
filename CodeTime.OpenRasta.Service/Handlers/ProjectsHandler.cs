using System.Collections.Generic;
using System.Linq;
using CodeTime.Domain.Projects;
using CodeTime.Infrastructure.Data;

namespace CodeTime.OpenRasta.Service.Handlers
{
    public class ProjectsHandler
    {
        readonly IRepository<Project> _Repository;

        public ProjectsHandler(IRepository<Project> repository)
        {
            _Repository = repository;
        }

        public IEnumerable<Project> Get()
        {
            return _Repository.GetAll().ToList();
        }
    }
}
using System.Collections.Generic;
using CodeTime.Infrastructure.Data;
using CodeTime.Projects.Entities;

namespace CodeTime.Projects.Services
{
    public class ProjectService : IProjectService
    {
        public ProjectService(IRepository<Project> repository)
        {
            _Repository = repository;
        }

        readonly IRepository<Project> _Repository;

        public IEnumerable<Project> GetProjects()
        {
            return _Repository.GetAll();
        }
    }
}
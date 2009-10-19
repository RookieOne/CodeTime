using System.Collections.Generic;
using System.Linq;
using CodeTime.Domain.Projects;
using CodeTime.Infrastructure.Attributes;
using CodeTime.Infrastructure.Data;
using CodeTime.Infrastructure.ViewModels;

namespace CodeTime.Wpf.CodeTimeModule.Projects
{
    public class ProjectsViewModel : ViewModel
    {
        readonly IRepository<Project> _Repository;

        public ProjectsViewModel(IRepository<Project> repository)
        {
            _Repository = repository;

            Projects = _Repository.GetAll().ToList();
        }

        [Notify]
        public IEnumerable<Project> Projects { get; set; }
    }
}
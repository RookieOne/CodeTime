using System.Collections.Generic;
using CodeTime.Projects.Entities;
using CodeTime.Projects.Services;

namespace CodeTime.Projects.Wpf.Projects
{
    public class ProjectsViewModel
    {
        public ProjectsViewModel(IProjectService service)
        {
            _Service = service;
            Projects = _Service.GetProjects();
        }

        readonly IProjectService _Service;

        public virtual IEnumerable<Project> Projects { get; set; }
    }
}
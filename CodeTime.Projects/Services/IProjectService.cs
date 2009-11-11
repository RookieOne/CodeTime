using System.Collections.Generic;
using CodeTime.Projects.Entities;

namespace CodeTime.Projects.Services
{
    public interface IProjectService
    {
        IEnumerable<Project> GetProjects();
    }
}
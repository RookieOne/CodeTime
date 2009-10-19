using CodeTime.Domain.Projects;
using FluentNHibernate.Mapping;

namespace CodeTime.Domain.Data.Projects
{
    public class ProjectMap : ClassMap<Project>
    {
        public ProjectMap()
        {
            Table("Projects");

            Id(x => x.Id).GeneratedBy.GuidComb();
            Map(x => x.Name);
        }
    }
}
using CodeTime.Domain.Projects;
using FluentNHibernate.Mapping;

namespace CodeTime.Domain.Data.Projects
{
    public class ProjectMap : ClassMap<Project>
    {
        public ProjectMap()
        {
            Table("Projects");

            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Areas).Cascade.All();
        }
    }
}
using CodeTime.Projects.Entities;
using FluentNHibernate.Mapping;

namespace CodeTime.Projects.Data.Maps
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
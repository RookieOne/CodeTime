using CodeTime.Domain.Projects;
using FluentNHibernate.Mapping;

namespace CodeTime.Domain.Data.Projects
{
    public class AreaMap : ClassMap<Area>
    {
        public AreaMap()
        {
            Table("Areas");

            Id(x => x.Id, "Id");

            Map(x => x.Name, "Name");
            References(x => x.Project);
            HasMany(x => x.Tasks).Cascade.All();
        }
    }
}
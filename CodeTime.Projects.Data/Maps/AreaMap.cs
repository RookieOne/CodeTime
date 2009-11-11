using CodeTime.Projects.Entities;
using FluentNHibernate.Mapping;

namespace CodeTime.Projects.Data.Maps
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
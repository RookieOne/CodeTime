using CodeTime.Projects.Entities;
using FluentNHibernate.Mapping;

namespace CodeTime.Projects.Data.Maps
{
    public class TaskMap : ClassMap<Task>
    {
        public TaskMap()
        {
            Table("Tasks");

            Id(x => x.Id, "Id");

            Map(x => x.Name, "Name");
            References(x => x.Area);
        }
    }
}
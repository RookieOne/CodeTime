using CodeTime.Domain.Projects;
using FluentNHibernate.Mapping;

namespace CodeTime.Domain.Data.Projects
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
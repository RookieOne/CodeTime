using System.Collections.Generic;

namespace CodeTime.Projects.Entities
{
    public class Project
    {
        public Project()
        {
            Areas = new List<Area>();
        }

        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual IList<Area> Areas { get; set; }

        public virtual void AddArea(Area area)
        {
            area.Project = this;
            Areas.Add(area);
        }
    }
}
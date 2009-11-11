using System.Collections.Generic;

namespace CodeTime.Projects.Entities
{
    public class Area
    {
        public Area()
        {
            Tasks = new List<Task>();
        }

        public virtual int Id { get; set; }
        public virtual Project Project { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Task> Tasks { get; set; }

        public virtual void AddTask(Task task)
        {
            task.Area = this;
            Tasks.Add(task);
        }
    }
}
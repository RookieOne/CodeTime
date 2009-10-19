using System;

namespace CodeTime.Domain.Projects
{
    public class Project
    {
        public virtual Guid Id { get; protected set; }
        public virtual string Name { get; set; }
    }
}
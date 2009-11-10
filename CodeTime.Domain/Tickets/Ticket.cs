using System;
using CodeTime.Domain.Projects;
using CodeTime.Domain.Users;

namespace CodeTime.Domain.Tickets
{
    public class Ticket
    {
        public virtual int Id { get; set; }
        public virtual DateTime Start { get; set; }
        public virtual DateTime End { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime Timestamp { get; set; }
        public virtual User User { get; set; }
        public virtual Project Project { get; set; }
        public virtual Area Area { get; set; }
        public virtual Task Task { get; set; }
    }
}
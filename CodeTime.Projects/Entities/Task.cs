namespace CodeTime.Projects.Entities
{
    public class Task
    {
        public virtual int Id { get; set; }
        public virtual Area Area { get; set; }
        public virtual string Name { get; set; }        
    }
}
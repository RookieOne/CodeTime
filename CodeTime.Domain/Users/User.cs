namespace CodeTime.Domain.Users
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
    }
}
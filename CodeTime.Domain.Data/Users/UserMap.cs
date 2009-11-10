using CodeTime.Domain.Users;
using FluentNHibernate.Mapping;

namespace CodeTime.Domain.Data.Users
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id);

            Map(x => x.FirstName);
            Map(x => x.LastName);
        }
    }
}
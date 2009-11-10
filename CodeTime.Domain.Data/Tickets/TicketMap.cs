using CodeTime.Domain.Tickets;
using FluentNHibernate.Mapping;

namespace CodeTime.Domain.Data.Tickets
{
    public class TicketMap : ClassMap<Ticket>
    {
        public TicketMap()
        {
            Table("Tickets");

            Id(x => x.Id);

            Map(x => x.Start);
            Map(x => x.End);
            Map(x => x.Timestamp);

            HasOne(x => x.User);
            HasOne(x => x.Project);
            HasOne(x => x.Area);
            HasOne(x => x.Task);
        }
    }
}
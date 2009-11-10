using CodeTime.Data;
using CodeTime.Domain.Data.Test.ContextSpecifications;
using CodeTime.Domain.Tickets;

namespace CodeTime.Domain.Data.Test.Tickets
{
    public class TicketRepository : SetupForNHibernate
    {
        protected Repository<Ticket> _Repository;

        protected override void Given()
        {
            base.Given();

            _Repository = new Repository<Ticket>(_Config);
        }
    }
}
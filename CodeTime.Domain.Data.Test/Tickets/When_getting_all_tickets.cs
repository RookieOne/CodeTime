using System;
using System.Collections.Generic;
using System.Linq;
using CodeTime.Domain.Tickets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTime.Domain.Data.Test.Tickets
{
    [TestClass]
    public class When_getting_all_tickets : TicketRepository
    {
        IEnumerable<Ticket> _Projects;

        protected override void When()
        {
            base.When();

            var ticket = new Ticket();
            ticket.Start = DateTime.Today.AddDays(-1);
            ticket.End = DateTime.Today;            

            _Repository.Save(ticket);

            _Projects = _Repository.GetAll();
        }

        [TestMethod]
        public void should_return_an_nonempty_collection()
        {
            Assert.AreNotEqual(0, _Projects.Count());
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using CodeTime.Domain.Projects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTime.Domain.Data.Test.Projects
{
    [TestClass]
    public class When_getting_all_projects : ProjectRepository
    {
        IEnumerable<Project> _Projects;

        protected override void When()
        {
            base.When();

            _Repository.Save(new Project());

            _Projects = _Repository.GetAll();
        }

        [TestMethod]
        public void should_return_an_nonempty_collection()
        {
            Assert.AreNotEqual(0, _Projects.Count());
        }
    }
}
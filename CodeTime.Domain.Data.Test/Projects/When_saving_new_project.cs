using System;
using System.Linq;
using CodeTime.Domain.Projects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTime.Domain.Data.Test.Projects
{
    [TestClass]
    public class When_saving_new_project : ProjectRepository
    {
        Project _NewProject;

        protected override void When()
        {
            base.When();

            _NewProject = new Project {Name = "New Project"};
            _Repository.Save(_NewProject);
        }

        [TestMethod]
        public void should_set_id_on_project()
        {            
            Assert.AreNotEqual(Guid.Empty, _NewProject.Id);
        }

        [TestMethod]
        public void should_save_project_in_database()
        {
            var newProject = _Repository.GetAll().FirstOrDefault(p => p.Id == _NewProject.Id);

            Assert.IsNotNull(newProject);
        }
    }
}
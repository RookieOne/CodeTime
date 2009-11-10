using System.Linq;
using CodeTime.Domain.Projects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTime.Domain.Data.Test.Projects
{
    [TestClass]
    public class When_saving_new_project_with_areas : ProjectRepository
    {
        Project _NewProject;

        protected override void When()
        {
            base.When();

            _NewProject = new Project {Name = "New Project"};
            _NewProject.AddArea(new Area {Name = "Area 1"});
            _NewProject.AddArea(new Area {Name = "Area 2"});

            _Repository.Save(_NewProject);
        }

        [TestMethod]
        public void should_set_id_on_project()
        {
            Assert.AreNotEqual(0, _NewProject.Id);
        }

        [TestMethod]
        public void should_save_project_in_database()
        {
            var newProject = _Repository.GetAll().FirstOrDefault(p => p.Id == _NewProject.Id);

            Assert.IsNotNull(newProject);
        }

        [TestMethod]
        public void should_save_areas_in_database()
        {
            var newProject = _Repository.GetAll().FirstOrDefault(p => p.Id == _NewProject.Id);

            Assert.AreEqual(2, newProject.Areas.Count);
        }
    }
}
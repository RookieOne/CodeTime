using System.Linq;
using CodeTime.Domain.Projects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTime.Domain.Data.Test.Projects
{
    [TestClass]
    public class When_saving_new_project_with_tasks : ProjectRepository
    {
        Project _NewProject;

        protected override void When()
        {
            base.When();

            _NewProject = new Project {Name = "New Project"};

            var area = new Area {Name = "Area 1"};
            area.AddTask(new Task {Name = "Task 1"});

            _NewProject.AddArea(area);

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
        public void should_save_area_in_database()
        {
            var newProject = _Repository.GetAll().FirstOrDefault(p => p.Id == _NewProject.Id);

            Assert.AreEqual(1, newProject.Areas.Count);
        }

        [TestMethod]
        public void should_save_task_in_database()
        {
            var newProject = _Repository.GetAll().FirstOrDefault(p => p.Id == _NewProject.Id);

            Assert.AreEqual(1, newProject.Areas[0].Tasks.Count);
        }
    }
}
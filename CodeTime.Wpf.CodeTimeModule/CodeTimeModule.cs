using CodeTime.Data;
using CodeTime.Domain.Projects;
using CodeTime.Infrastructure.Data;
using CodeTime.Infrastructure.IoC;

namespace CodeTime.Wpf.CodeTimeModule
{
    public class CodeTimeModule
    {
        public void Initialize()
        {
        }

        public void Configure(ICodeTimeIoC container)
        {
            container.Register<IRepository<Project>, Repository<Project>>();
        }
    }
}
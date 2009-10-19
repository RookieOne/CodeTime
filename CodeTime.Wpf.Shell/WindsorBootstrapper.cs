using CodeTime.Windsor;

namespace CodeTime.Wpf.Shell
{
    public class CodeTimeBootstrapper
    {
        public void ConfigureContainer()
        {
            var container = new CodeTimeWindsor();

            var module = new CodeTimeModule.CodeTimeModule();
            module.Configure(container);
        }
    }
}
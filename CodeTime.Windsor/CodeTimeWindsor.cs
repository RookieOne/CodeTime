using Castle.Windsor;
using CodeTime.Infrastructure.IoC;

namespace CodeTime.Windsor
{
    public class CodeTimeWindsor : ICodeTimeIoC
    {
        readonly IWindsorContainer _Container;

        public CodeTimeWindsor()
        {
            _Container = new WindsorContainer();
        }

        public ICodeTimeIoC Register<TInterface, TConcrete>() where TConcrete : class
        {
            _Container.AddComponent<TInterface, TConcrete>();
            return this;
        }
    }
}
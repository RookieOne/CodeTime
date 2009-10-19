namespace CodeTime.Infrastructure.IoC
{
    public interface ICodeTimeIoC
    {
        ICodeTimeIoC Register<TInterface, TConcrete>() where TConcrete : class;
    }
}
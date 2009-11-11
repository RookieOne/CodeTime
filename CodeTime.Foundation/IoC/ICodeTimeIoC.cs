namespace CodeTime.Foundation.IoC
{
    public interface IIoC
    {
        IIoC Register<TInterface, TConcrete>() where TConcrete : class;
        IIoC RegisterSingleton<TInterface, TConcrete>() where TConcrete : class;
    }
}
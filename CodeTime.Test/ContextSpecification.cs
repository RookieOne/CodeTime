using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTime.Test
{
    public abstract class ContextSpecification
    {
        [TestInitialize]        
        public void Initialize()
        {
            Given();
            When();
        }

        protected virtual void Given()
        {
        }

        protected virtual void When()
        {
        }
    }
}
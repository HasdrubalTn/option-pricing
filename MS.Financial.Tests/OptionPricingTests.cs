using MS.Financial.Core;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Calculate_Option_Call_Price()
        {
            var mediator = new OptionMediator();

            var price = mediator.Calculate(120);

            Assert.Pass();
        }
    }
}
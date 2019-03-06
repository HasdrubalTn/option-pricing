using MS.Financial.Contracts.Entities;
using MS.Financial.Contracts.Interfaces;

namespace MS.Financial.Core
{
    public class OptionMediator
    {
        public IOptionFactory GetFactory()
        {
            return new EuropeanOptionFactory();
        }

        public double Calculate(double underlingPrice)
        {
            //Get the factory
            var factory = GetFactory();

            //Create the option
            Option option = factory.Create(0.08,0.30,65.0,0.25,0.08,OptionType.Call);

            //Create the manager
            var manager = new EuropeanOptionManager();

            //Calculate the option price
            return manager.Price(option, underlingPrice);
        }
    }
}

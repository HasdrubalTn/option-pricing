using MS.Financial.Contracts.Entities;
using MS.Financial.Contracts.Interfaces;

namespace MS.Financial.Core
{
    public class EuropeanOptionFactory : IOptionFactory
    {
        public Option Create(double r, double sig, double k, double t, double b, OptionType type)
        {
            return new Option(r, sig, k, t, b, type);
        }
    }
}

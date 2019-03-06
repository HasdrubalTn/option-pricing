using MS.Financial.Contracts.Entities;
using System;

namespace MS.Financial.Contracts.Interfaces
{
    public interface IOptionFactory
    {
        Option Create(double r, double sig, double k, double t, double b, OptionType type);
    }
}

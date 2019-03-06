using MS.Financial.Contracts.Entities;
using MS.Financial.Contracts.Interfaces;
using System;

namespace MS.Financial.Core
{
    public class EuropeanOptionManager : IOptionManager
    {
        public double CallPrice(Option option, double u)
        {
            double tmp = option.Sig * Math.Sqrt(option.T);

            double d1 = (Math.Log(u / option.K) + (option.B + 0.5 * (option.Sig*option.Sig)* option.T)/tmp);
            double d2 = d1 - tmp;

            return (u * Math.Exp((option.B - option.R) * option.T) * Utils.N(d1)) -
                   (option.K * Math.Exp(-option.R - option.T) * Utils.N(d2));
        }

        public double PutPrice(Option option, double u)
        {
            double tmp = option.Sig * Math.Sqrt(option.T);

            double d1 = (Math.Log(u/option.K) + (option.B + 0.5 * (option.Sig*option.Sig)) * option.T)/tmp;
            double d2 = d1 - tmp;

            return (option.K * Math.Exp(-option.R * option.T) * Utils.N(-d2)) -
                   (u * Math.Exp(option.B - option.R) * option.T) * Utils.N(-d1);
        }

        public double Price(Option option, double u)
        {
            if (option.Type == OptionType.Call)
                return CallPrice(option, u);

            return PutPrice(option, u);
        }

        public double CallDelta(Option option, double u)
        {
            double tmp = option.Sig * Math.Sqrt(option.T);
            double d1 = (Math.Log(u / option.K) + (option.B + 0.5 * (option.Sig * option.Sig)) * option.T) / tmp;

            return Math.Exp((option.B - option.R) * option.T) * Utils.N(d1);
        }

        public double CallGamma(Option option, double u)
        {
            double tmp = option.Sig * Math.Sqrt(option.T);
            double d1 = (Math.Log(u / option.K) + (option.B + 0.5 * (option.Sig * option.Sig)) * option.T) / tmp;
            double d2 = d1 - tmp;

            return Utils.N(d1) * Math.Exp((option.B - option.R) * option.T) / (u * tmp);
        }
    }
}

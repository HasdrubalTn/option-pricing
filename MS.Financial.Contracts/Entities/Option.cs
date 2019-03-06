using System;
using System.Collections.Generic;
using System.Text;

namespace MS.Financial.Contracts.Entities
{
    public enum OptionGreeks
    {
        Price       = 0,
        Delta       = 1,
        Gamma       = 2,
        Theta       = 3,
        Vega        = 4,
        Rho         = 5,
        CostOfCarry = 6
    }
    public enum OptionType
    {
        Call        = 0,
        Put         = 1,
        CallDelta   = 2
    }

    public class Option
    {
        public double R { get; set; }          //Interest rate
        public double Sig { get; set; }        //Volatility
        public double K { get; set; }          //Strike price
        public double T { get; set; }          //Maturity date
        public double B { get; set; }          //Cost of carry
        public OptionType Type { get; set; }   //Option name (call, put)

        public Option(double r, double sig, double k, double t, double b, OptionType type)
        {
            R = r;
            Sig = sig;
            K = k;
            T = t;
            B = b;
            Type = type;
        }

        public Option()
        {

        }
    }
}

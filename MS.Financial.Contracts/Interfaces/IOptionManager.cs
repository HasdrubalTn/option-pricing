using MS.Financial.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MS.Financial.Contracts.Interfaces
{
    public interface IOptionManager
    {
        double CallPrice(Option option, double u);
        double PutPrice(Option option, double u);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalc.Core.Services
{
    public class Calculation : ICalculation
    {
        public double TipAmout(double subTotal, int generosity)
        {
            return subTotal*((double) generosity)/100.0;
        }
    }
}

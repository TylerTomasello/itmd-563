using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Github link: https://github.com/TylerTomasello/itmd-563/tree/master/Proj7-grad-tomasello

namespace Proj7_grad_tomasello
{
    public class CalculateMortgage
    {
        //Calculate the monthly payment of the principle, years, and rate
        public static double CalcMonthlyPayment(double principle, double years, double Rate)
        {
            double top = principle * Rate / 1200.00;
            double bottom = 1 - Math.Pow(1.00 + Rate / 1200.00, -12.00 * years);
            double monthly = top / bottom;
            return monthly;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proj5_grad_tomasello
{
    public interface IIOHelper
    {
        List<PaymentInfo> ListAllMortgages();
        void AddMortgages(string formattedTempString, float formattedPrinciple, float formattedYears, float formattedRate);
        void ClearAllMortgages();
    }
}
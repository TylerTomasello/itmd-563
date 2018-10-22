using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proj5_grad_tomasello
{
    public interface IIOHelper
    {
        List<string> ListAllMortgages();
        void AddMortgages(string formattedTempString);
        void ClearAllMortgages();
    }
}
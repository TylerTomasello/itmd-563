using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proj3_Tomasello
{
    public interface IIOHelper
    {
        List<string> ListAllMortgages();
        void AddMortgages(string formattedTempString);
        void ClearAllMortgages();
    }
}
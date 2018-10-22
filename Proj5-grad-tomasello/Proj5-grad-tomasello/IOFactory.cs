using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proj5_grad_tomasello
{
    public class IOFactory
    {
        public static IIOHelper CreateIOEngine()
        {
            return new DatabaseIOHelper();
        }
    }
}
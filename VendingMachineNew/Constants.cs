using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VendingMachineNew
{
    public static class Constants
    {
        public static Dictionary<string,Double> exchangeValue = new Dictionary<string,double>()
        {
            {"Nickels",0.2}, {"Dimes",0.1}, {"Quarters",0.25}
        };
        public static Dictionary<int, string> currencyType = new Dictionary<int, string>()
        {
            {1,"Nickels"}, {2,"Dimes"}, {3,"Quarters"},{4,"pennies"}
        };
    }
}
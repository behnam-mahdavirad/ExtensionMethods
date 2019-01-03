using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExtensionMethods.Models
{
    public static class ExtensionStatics
    {
        public static bool IsInteger(this string str)
        {
            int output;
            return Int32.TryParse(str, out output);
        } // end method IsNumeric

    } // end class ExtensionStatics

} // end namespace ExtensionMethods.Models
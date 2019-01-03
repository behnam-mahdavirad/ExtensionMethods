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

        public static int CountWords(this string str)
        {
            return str.Split(new char[] { ' ', '.', ',' }).Length;
        } // end method CountWords

    } // end class ExtensionStatics

} // end namespace ExtensionMethods.Models
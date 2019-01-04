using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExtensionMethods.Models
{
    public static class ExtensionStatics
    {
        /// <summary>
        /// Check if the input string is Integer or not
        /// </summary>
        /// <param name="str"></param>
        /// <returns>bool</returns>
        public static bool IsInteger(this string str)
        {
            int output;
            return Int32.TryParse(str, out output);
        } // end method IsNumeric

        /// <summary>
        /// Count all words in a given string
        /// </summary>
        /// <param name="str">string to begin with</param>
        /// <returns>int</returns>
        public static int CountWords(this string str)
        {
            return str.Split(new char[] { ' ', '.', ',' }).Length;
        } // end method CountWords

    } // end class ExtensionStatics

} // end namespace ExtensionMethods.Models
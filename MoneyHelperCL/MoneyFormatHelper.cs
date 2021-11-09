using System;
using System.Text.RegularExpressions;

namespace MoneyHelperCL
{
    public class MoneyFormatHelper
    {
        /// <summary>
        /// Set numeric separator and decimal valid
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="number"></param>
        /// <param name="maxDecimals"></param>
        /// <returns></returns>
        public string FormatNumber<T>(T number, int maxDecimals = 4)
        {
            return Regex.Replace(String.Format("{0:n" + maxDecimals + "}", number),
                                 @"[" + System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator + "]?0+$", "");
        }
    }
}

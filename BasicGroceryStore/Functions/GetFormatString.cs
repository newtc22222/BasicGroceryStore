using System;
using System.Globalization;

namespace BasicGroceryStore
{

    internal static class GetFormatString
    {
        /// <summary>
        /// Making id by using Date and Time (when it was called)
        /// </summary>
        /// <returns>string id</returns>
        public static string MakingIDNow()
        {
            return DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() +
                   DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
        }

        /// <summary>
        /// Get a string to use for sql query
        /// </summary>
        /// <param name="date"></param>
        /// <returns>string with format YYYY-MM-DD</returns>
        public static string GetDateString(DateTime date)
        {
            return date.Year + "-" + date.Month + "-" + date.Day;
        }

        /// <summary>
        /// Get Vietnamese currency string format
        /// </summary>
        /// <param name="value"></param>
        /// <returns>###,###,### đ</returns>
        public static string GetCurrencyString(double value)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
            return value.ToString("#,###", cul.NumberFormat) + " vnđ";
        }
    }
}

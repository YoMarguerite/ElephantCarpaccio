using System;
using System.Collections.Generic;
using System.Text;

namespace ElephantCarpaccio
{
    public abstract class Formatter
    {
        public static string FormatString(string value)
        {
            string format = value.ToUpper();
            if (format.Length > 10)
            {
                return format.Substring(0, 10);
            }
            string result = format.PadRight(10);
            return result;
        }

        public static string FormatInt(int value)
        {
            return String.Format("{0:0000000000}", value);
        }

        public static string FormatFloat(float value)
        {
            return String.Format("{0:000000.00}", Math.Round(value, 2));
        }

        public static string FormatPrice(float value)
        {
            return FormatFloat(value) + "$";
        }
    }
}

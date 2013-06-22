using System;

namespace Methods
{
    public class StringUtils
    {
        public static string DigitToString(int digit)
        {
            switch (digit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new ArgumentOutOfRangeException("Out of the range [0-9].");
            }
        }

        public static string FormatNumber(double number, string format)
        {
            switch (format)
            {
                case "f":
                    return string.Format("{0:f2}", number);
                case "%":
                    return string.Format("{0:p0}", number);
                case "r":
                    return string.Format("{0,8}", number);
                default:
                    throw new ArithmeticException("Invalid formating option");
            }
        }
    }
}
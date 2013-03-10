using System;
using System.Text;

namespace ExtentionStringBuilder
{
    static public class SubstringSB
    {
        //Simply create new StringBuulder and use the fact we can create it by using a string
        //Then Passing params to the ToString and then returning the value
        public static StringBuilder Substring(this StringBuilder strBuild, int startIndex, int length)
        {
            StringBuilder subString = new StringBuilder(strBuild.ToString(startIndex, length));
            return subString;
        }
    }
}
using System;
using System.Text;

namespace ExtentionStringBuilder
{
    class TestSB
    {
        static void Main(string[] args)
        {
            //Just basic test
            StringBuilder test = new StringBuilder("Just a test to see how it works");
            StringBuilder result = test.Substring(7, 15);
            Console.WriteLine("Old SB: {0}", test);
            Console.WriteLine("New SB: {0}", result);
        }
    }
}
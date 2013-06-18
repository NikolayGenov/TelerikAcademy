using System;

namespace Methods
{
    public class Tests
    {
        static void Main()
        {
            //StatisticUtils Tests
            Console.WriteLine("StatisticUtils Tests");
            Console.WriteLine("The Max of the numbers '5, -1, 3, 2, 14, 2, 3' is :{0}", StatisticUtils.Max(5, -1, 3, 2, 14, 2, 3));
            Console.WriteLine();

            //StringUtils Tests
            Console.WriteLine("StringUtils Tests");
            Console.WriteLine("The digit 5 to string is: {0}", StringUtils.DigitToString(5));
            Console.WriteLine("Different Formats");
            Console.WriteLine(StringUtils.FormatNumber(1.3, "f"));
            Console.WriteLine(StringUtils.FormatNumber(0.75, "%"));
            Console.WriteLine(StringUtils.FormatNumber(2.30, "r"));
            Console.WriteLine();

            //GeometryUtils Tests
            Console.WriteLine("GeometryUtils Tests");
            Console.WriteLine("Trinagle with sides '3,4,5' has area: {0}", GeometryUtils.CalcTriangleArea(3, 4, 5));
            Console.WriteLine("Distance between the two lines is: {0}", GeometryUtils.CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + GeometryUtils.IsHorizontalLine(3, -1, 3.0, 2.5));
            Console.WriteLine("Vertical? " + GeometryUtils.IsVerticalLine(3, -1, 3.0, 2.5));
            Console.WriteLine();

            //Student Tests
            Console.WriteLine("Student Tests");
            Student peter = new Student(firstName: "Peter", lastName: "Ivanov", dateOfBirth: "17/03/1992");
            peter.OtherInfo = "From Sofia.";
            
            Student stella = new Student(firstName: "Stella", lastName:"Markova", dateOfBirth: "03/11/1993");
            stella.OtherInfo = "From Vidin, gamer, high results.";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
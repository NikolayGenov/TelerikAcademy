using System;

namespace ExceptionProject
{
    class TestClass
    {
        static void Main(string[] args)
        {
            //Tests
            int testNumber = 253;
            TestIntException(testNumber);
            testNumber = 53;
            TestIntException(testNumber);
            DateTime testDate = new DateTime(1959, 3, 5);
            TestDateException(testDate);
            testDate = new DateTime(2059, 7, 8);
            TestDateException(testDate);
            testDate = new DateTime(1999, 1, 1);
            TestDateException(testDate);
        }

        private static void TestIntException(int testNumber)
        {
            //Test methods for start and stop range check
            int startRange = 0;
            int stopRange = 100;
            try
            {
                if (testNumber > stopRange || startRange < 0)
                {
                    throw new InvalidRangeException<int>(startRange, stopRange);
                }
                Console.WriteLine("Woo - hoo no exceptions");
            }
            catch (InvalidRangeException<int>)
            {
                Console.WriteLine("The INT test-exception is caught successfully");
            }
        }

        private static void TestDateException(DateTime testDate)
        {
            //Same but with datetime as template
            DateTime startRange = new DateTime(1980, 1, 1);
            DateTime stopRange = new DateTime(2013, 12, 31);
            try
            {
                if (testDate.CompareTo(startRange) < 0 || testDate.CompareTo(stopRange) > 0) // 
                {
                    throw new InvalidRangeException<DateTime>(startRange, stopRange);
                }
                Console.WriteLine("Woo - hoo no exceptions");
            }
            catch (InvalidRangeException<DateTime>)
            {
                Console.WriteLine("The DateTime test-exception is caught successfully");
            }
        }
    }
}
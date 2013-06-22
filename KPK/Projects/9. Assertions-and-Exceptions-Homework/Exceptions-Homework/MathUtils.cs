using System;

namespace Exceptions_Homework
{
   public class MathUtils
    {
        public static bool IsPrime(int number)
        {
            bool isPrime = false;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Number must be positive");
            }
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    isPrime = true;
                    break;
                }
            }
            return isPrime;
        }
    }
}
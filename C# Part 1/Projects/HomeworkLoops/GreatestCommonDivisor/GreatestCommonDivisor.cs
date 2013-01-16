using System;


    class GreatestCommonDivisor
    {
        static void Main()
        {
            Console.WriteLine("Enter X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y");
            int y = int.Parse(Console.ReadLine());
            //Imprementing Euclidean algorithm 
            int gcd = 1;
            while (x != 0 && y != 0)
            {
                if (x>y)
                {
                    x %= y;
                    
                }
                else
                {
                    y %= x;
                }
            }
            if (x==0)
            {
                gcd = y;  
            }
            else
            {
                gcd = x;
            }
            Console.WriteLine("Greatest common divisor of the 2 numbers is: {0}",gcd);
        }
    }


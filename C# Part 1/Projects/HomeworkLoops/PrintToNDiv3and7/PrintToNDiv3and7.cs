using System;

 class PrintToNDiv3and7
    {
        static void Main()
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers that are (removing all the numbers divisible by 3 and 7 at the same time):");
            for (int i = 1; i <= n; i++)
            {
                if (!((i%3==0)&&(i%7==0)))
                {
                    Console.WriteLine(i);
                }
            }
        }
   }


using System;

class PrintMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        if (n < 20 && n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n + i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }            
        }
        else
        {
            Console.WriteLine("ERROR");
        }
    }
}
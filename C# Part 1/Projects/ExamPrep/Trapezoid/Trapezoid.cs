using System;

class Trapezoid
{
    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());
        string star = "*";
        string dot = ".";
        int row = 1,col = 1;
        int pos = N;
        for (row = 1; row <= 2 * N; row++)
        {
            if (row <= N)
            {
                Console.Write(dot);
            }
            else
            {
                Console.Write(star);
            }
        }
        Console.WriteLine();
        for (col = 2; col <= N; col++)
        {
            for (row = 1; row <= 2 * N; row++)
            {
                if ((N - (col) + 2 == row) || row == 2 * N)
                {
                    Console.Write(star);
                }
                else
                {
                    Console.Write(dot);
                }               
            }
            Console.WriteLine();
        }
        for (row = 0; row < 2 * N; row++)
        {
            Console.Write(star);
        }
    }
}
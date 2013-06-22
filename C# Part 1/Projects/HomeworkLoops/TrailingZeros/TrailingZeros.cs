using System;

class TrailingZeros
{
    static void Main()
    {
        Console.WriteLine("Enter N!:");
        int n = int.Parse(Console.ReadLine());
        int countFive = 0;   
        for (int i = 1; i <= n; i++)
        {
            int num = i;
            while (num % 5 == 0)
            {
                countFive++;
                num /= 5;
            }
        }
        Console.WriteLine("The zeros in the end of {1}! are : {0}", countFive, n);
    }
}
using System;

class PrintMatrix3
{
    static void Main()
    {
        //Takes user info and create the array
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        int value = 0;
        int counter = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                value++;
                arr[j, (n - 1) - i + j] = value;
            }
        }
        value = n * n;
        for (int i = (n - 1); i >= 1; i--)
        {
            for (int j = n - i - 1; j >= 0; j--)
            {
                arr[i + j, j] = value;

                value--;
            }
        }
        
    }
}
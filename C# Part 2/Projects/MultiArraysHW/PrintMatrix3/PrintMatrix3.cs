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
        //Print the part below and uncluding the main diagonal
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                value++;
                arr[j, (n - 1) - i + j] = value;
            }
        }
        value = n * n;
        //Print the remaining stuff starting from the max value 
        for (int i = (n - 1); i >= 1; i--)
        {
            for (int j = n - i - 1; j >= 0; j--)
            {
                arr[i + j, j] = value;

                value--;
            }
        }

        //Print the result on the console
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                Console.Write("{0,3} ", arr[row, col]);
            }
            Console.WriteLine();
        }
    }
}
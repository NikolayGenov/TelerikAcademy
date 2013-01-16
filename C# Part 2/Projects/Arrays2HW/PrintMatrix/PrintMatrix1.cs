using System;

class PrintMatrix1
{
    static void Main(string[] args)
    {
        //Takes user info and create the array
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];

        //Fill the matrix with the info in the desired order
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                arr[row, col] = (col * n + row + 1);
                Console.Write("{0,3} ", arr[row, col]);
            }
            Console.WriteLine();
        }
        
    }
}
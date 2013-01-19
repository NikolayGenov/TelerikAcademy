using System;

class PrintMatrix2
{
    static void Main(string[] args)
    {
        //Takes user info and create the array
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        int value = 0;
        //Fill the matrix
        for (int row = 0; row < n; row++)
        {
            //If we have odd or even there are 2 cases and continue to inc the value
            if (row % 2 == 0)
            {
                for (int col = 0; col < n; col++)
                {
                    value++;
                    arr[row, col] = value;
                   
                }
            }
            else
            {
                for (int col = n - 1; col >= 0; col--)
                {
                    value++;
                    arr[row, col] = value;
                   
                }
            }            
        }
        //Print the result 
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
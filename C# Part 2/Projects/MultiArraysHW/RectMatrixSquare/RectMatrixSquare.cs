using System;

class RectMatrixSquare
{
    static void Main()
    {
        Console.WriteLine("Enter N (rows):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter M (cols)");
        int m = int.Parse(Console.ReadLine());
        if ((m < 3) || (n < 3))
        { //There is no need to continue to search for 3x3 square if the matrix isn't at least that big
            Console.WriteLine("Please enter numbers greater than 3");
        }
        else
        { //Create the matrix and enter the numbers with a method using ref
            int[,] matrix = new int[n, m];
            EnterNumbers(n, m, ref matrix);
            int tempSum = 0; //temp sum and max sum for the max result
            int maxSum = int.MinValue;
            //Using method to find the max sum and then output the result
            FindMaxSum(n, m, matrix, ref tempSum, ref maxSum);
            Console.WriteLine("The maximum sum is {0}", maxSum);
        }
    }
  
    private static void FindMaxSum(int n, int m, int[,] matrix, ref int tempSum, ref int maxSum)
    {
        for (int i = 0; i <= n - 3; i++)
        {
            for (int j = 0; j <= m - 3; j++)
            { //Adding all the possible possitions to a temp value and then compare with the result
                tempSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                          matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                          matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                }
            }
        }
    }
  
    private static void EnterNumbers(int n, int m, ref int[,] matrix)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Matrix [{0}/{1},{2}/{3}]= ", i + 1, n, j + 1, m);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
}
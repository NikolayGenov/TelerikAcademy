using System;

class RectMatrixSquare
{
    static void Main()
    {
        Console.WriteLine("Enter N (rows):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter M (cols)");
        int m = int.Parse(Console.ReadLine());
        //check if m and N <  3
        int[,] matrix = new int[n, m];
        EnterNumbers(n, m, matrix);

       
    }
  
    private static void EnterNumbers(int n, int m, int[,] matrix)
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


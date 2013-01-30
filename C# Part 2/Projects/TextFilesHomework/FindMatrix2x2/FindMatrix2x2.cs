using System;
using System.IO;

class FindMatrix2x2
{
    static void Main()
    {
        //Read the file
        using (StreamReader matrixFile = new StreamReader(@"../../matrix.txt")) 
        {
            //Take the first row as a size of the matrix and create a matrix that big
            int sizeOfMatrix = int.Parse(matrixFile.ReadLine());
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            //Read every row and put the values into the matrix array
            for (int i = 0; i < sizeOfMatrix; i++)
            {
                string row = matrixFile.ReadLine();                
                string[] arr = row.Split(' ');
                for (int k = 0; k < sizeOfMatrix; k++)
                {
                    matrix[i, k] = (int.Parse(arr[k]));
                }
            }
            //Look for 2 by 2 square with max sum and compare it with temp sum 
            int maxSum = int.MinValue ;
            int tempSum = 0;
            for (int i = 0; i < sizeOfMatrix - 1; i++)
            {
                for (int j = 0; j < sizeOfMatrix - 1; j++)
                {
                    tempSum = matrix[i, j] + matrix[i, j + 1] +
                              matrix[i + 1, j] + matrix[i + 1, j + 1];
                }
                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                }
            }
            //Write the result in a new file
            using (StreamWriter matrixOutput = new StreamWriter(@"../../matrixResult.txt"))
            {
                matrixOutput.WriteLine("The max sum of 2x2 square is {0}", maxSum);
            }
            Console.WriteLine("Done!");
        }
    }
}
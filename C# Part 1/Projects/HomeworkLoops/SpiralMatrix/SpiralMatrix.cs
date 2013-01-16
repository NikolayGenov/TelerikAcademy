using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int N = int.Parse(Console.ReadLine());
        if (N < 20 && N > 0)
        {
            int[,] matrix = new int[N, N];
            int setOfNums = N, value = 1, number = 1;
            while (N / number >= 2) //Filling the matrix except the last one in 2n+1 case
            {
                for (int i = number - 1; i <= setOfNums - 1; i++)
                {
                    matrix[number - 1, i] = value;
                    value++;
                }
                for (int j = number; j <= setOfNums - 1; j++)
                {
                    matrix[j, setOfNums - 1] = value;
                    value++;
                }
                for (int i = setOfNums - 2; i >= number - 1; i--)
                {
                    matrix[setOfNums - 1, i] = value;
                    value++;
                }
                for (int j = setOfNums - 2; j >= number; j--)
                {
                    matrix[j, number - 1] = value;
                    value++;
                }
                number++;
                setOfNums--;
            }
            //The case for the last one in 2n+1
            if (N % 2 != 0)
            {
                matrix[number - 1, number - 1] = value;
            }

            //Printing out the matrix
            Console.WriteLine("The matrix is :");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,4}",matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Wrong input data");
        }
    }
}


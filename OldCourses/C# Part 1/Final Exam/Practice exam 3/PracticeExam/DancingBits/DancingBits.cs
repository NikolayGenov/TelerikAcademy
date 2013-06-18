using System;

class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string bits = null;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            bits += Convert.ToString(number, 2);
        }
        int[] matrix = new int[bits.Length];
        int counter = 0;
        int resultCounter = 0;       
        int same = 1;
        for (int i = 0; i < bits.Length - 1; i++)
        {
            if (bits[i] == bits[i + 1])
            {
                same++;
                if (i == bits.Length - 2)
                {
                    matrix[counter] = same;
                }
            }
            else
            {               
                matrix[counter] = same;
                counter++;
                if (i == bits.Length - 2)
                {
                    matrix[counter] = 1;
                }
                same = 1;
            }
        }
        for (int i = 0; i < matrix.Length; i++)
        {
            if (matrix[i] == k)
            {
                resultCounter++;
            }
        }
        Console.WriteLine(resultCounter);
    }
}
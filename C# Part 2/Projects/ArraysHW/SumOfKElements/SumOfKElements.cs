using System;

class SumOfKElements
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        if (n != 0)
        {
            int maskValues = (int)(Math.Pow(2, n));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Array [{0}/{1}]= ", i + 1, n);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int maxSum = 0, sum = 0;
            ;
            for (int i = 0; i < maskValues; i++)
            {
                int[] mask = new int[n];
                sum = 0;
                MakeMask(n, k, i, mask);
                for (int j = 0; j < n; j++)
                {
                    sum += mask[j] * arr[j];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }
            Console.WriteLine("The max sum is {0}", maxSum);
        }
        else
        {
            Console.WriteLine("There are no numbers in the array");
        }
    }

    private static void MakeMask(int n, int k, int pos, int[] mask)
    {
        int i = 0;
        int temp = 0;
        int counter = 0;
        while ((pos > 0) && (counter != k))
        {
            temp = pos % 2;
            if (temp == 1)
            {
                counter++;
            }
            mask[i] = temp;
            pos /= 2;
            i++;
        }
    }
}
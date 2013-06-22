using System;

namespace SumOfSubset
{
    class SumOfSubset
    {
        static int[] mask = new int[5];

        static void makeMask(int pos)
        {
            int i = 0;
            while (pos > 0)
            { 
                mask[i] = pos % 2;
                pos /= 2;
                i++;               
            }
        }
     
        static void Main()
        {
            bool isZero = false;
            int sum = 0;
            int[] arr = new int[5];
            int n = 5; //Given 5 intergers
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter a number: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 1; j < 32; j++)
            {
                makeMask(j);
                for (int i = 0; i < n; i++)
                {
                    sum += (arr[i] * mask[i]);
                }
                if (sum == 0)
                {
                    isZero = true;
                }
                sum = 0;
            }
            if (isZero)
            {
                Console.WriteLine("There is a subset of which the sum of the elements is 0 ");
            }
            else
            {
                Console.WriteLine("There isn't any subset which sum is equal to 0");
            }
        }
    }
}
using System;

namespace SumOfSubset
{
    class SumOfSubset
    {
       
        static void makeMask(int pos,int [] mask)
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
            
            
            long s = long.Parse(Console.ReadLine());
            int counter = 0;
            long n = long.Parse(Console.ReadLine()); //Given 5 intergers
            long[] arr = new long[n];
            long sum = 0;
            for (int i = 0; i < n; i++)
            {

                arr[i] = long.Parse(Console.ReadLine());
            }
            long stopValue = 2<<((int)n-1);
            for (int j = 1; j <stopValue; j++)
            {int[] mask = new int[n];
                makeMask(j,mask);
                for (int i = 0; i < n; i++)
                {
                    sum += (arr[i] * mask[i]);
                }
                if (sum == s)
                {
                    counter++;
                }
                sum = 0;
            }
            Console.WriteLine(counter);
            
        }
    }
}
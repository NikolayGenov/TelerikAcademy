using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int[] arr = new int[5];
        for (int i = 0; i < 5; i++)
            arr[i] = byte.Parse(Console.ReadLine());

        byte countTo3;
        long maxCase = 100000000000;
        for (int result = 1; result < maxCase; result++)
        {
            countTo3 = 0;
            for (int i = 0; i < 5; i++)
            {
                if (result % arr[i] == 0)
                    countTo3++;
            }
            if (countTo3 >= 3)
            {
                Console.WriteLine(result);
                break;
            }
        }
    }
}
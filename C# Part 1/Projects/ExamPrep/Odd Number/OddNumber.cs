using System;

class OddNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] arrayOfNum = new long[n];
        for (int entry = 0; entry < n; entry++)
        {
            arrayOfNum[entry] = long.Parse(Console.ReadLine());
        }
        Array.Sort(arrayOfNum);
        int index = 0;
        bool isTrue = true;
        while (isTrue && arrayOfNum.Length > index)
        {
            if (index + 1 < arrayOfNum.Length)
            {
                if ((arrayOfNum[index] == arrayOfNum[index + 1]))
                {
                    index += 2;
                }
                else
                {
                    Console.WriteLine(arrayOfNum[index]);
                    isTrue = false;
                }
            }
            else
            {
                Console.WriteLine(arrayOfNum[index]);
                isTrue = false;
            }
        }
    }
}
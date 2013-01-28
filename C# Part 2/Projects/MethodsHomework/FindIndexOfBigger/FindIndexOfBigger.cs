using System;

class FindIndexOfBigger
{
    static void Main()
    {
        int[] array = { 3, 1, 3, 5, 63, 4, 6, 856, 5, 6, 8 };
        Console.WriteLine("Array  (from 0 to {0}) ", array.Length - 1);

        int pos = FindElement(array);
        if (pos != -1)
        {
            Console.WriteLine("The possion in the array where the number is bigger than its neighbors is {0}", pos);
        }
        else
        {
            Console.WriteLine("There is no such number");
        }
    }
  
    private static int FindElement(int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (CheckElement(i, array))
                return i;
        }
        return -1;
    }

    private static bool CheckElement(int pos, int[] array)
    {
        if ((array[pos - 1] < array[pos]) && (array[pos] > array[pos + 1]))
        {
            return true;
        }
        return false;
    }
}


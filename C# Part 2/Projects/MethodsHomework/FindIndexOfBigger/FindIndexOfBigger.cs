using System;

class FindIndexOfBigger
{
    static void Main()
    {
        //Predefined array
        int[] array = { 3, 1, 3, 5, 63, 4, 6, 856, 5, 6, 8 };
        Console.WriteLine("Array  (from 0 to {0}) ", array.Length - 1);

        //calling the method to determine the possition and if its none it returns -1
        int pos = FindElement(array);
        //Just print the result
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
        //Looping from the beggining to the end and for each element we call the method check element
        //which returns boolean result
        //If we find we take the possion - i
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (CheckElement(i, array))
                return i;
        }
        return -1;
    }

    private static bool CheckElement(int pos, int[] array)
    {
        //Check if there is such element which is bigger than its neig...
        if ((array[pos - 1] < array[pos]) && (array[pos] > array[pos + 1]))
        {
            return true;
        }
        return false;
    }
}


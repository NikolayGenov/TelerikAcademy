using System;

class BiggerThanNeighbors
{
    static void Main()
    {
        int[] array = { 6, 9, 6, 5, 6, 87, 6, 8, 4, 3, 4, 6 };
        Console.WriteLine("Enter possition (from 1 to {0}) ", array.Length - 2);
        int pos = int.Parse(Console.ReadLine());
        if (!((pos >= 1) && (pos <= array.Length - 2)))            
        {
            Console.WriteLine("Not a valid possition");
        }
        else
        {
            if (CheckElement(pos, array))
            {
                Console.WriteLine("The element on the given possion is bigger than its two neighbors");
            }
            else
            {
                Console.WriteLine("The element on that possion is NOT bigger than its two neighbors");
            }
        }
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
using System;

class TimesInArray
{
    static void Main()
    {
        int[] array = { 4, 5, 6, 7, 8, 4, 5, 67, 2, 1, 7, 8, 4, 2, 3, 4, 8, 4, 3, 4, 1, 8, 4, 6, 8, 9, 0, 1, 3, 4, 5, 6 };
        Console.WriteLine("Enter number to search");
        int key = int.Parse(Console.ReadLine());
        int counter = CountNumbers(key, array);
        if (counter != 0)
        {
            Console.WriteLine("The number you are looking for is found {0} times in the array", counter);
        }
        else
        {
            Console.WriteLine("The number you've entered is NOT found in the array");
        }
    }

    private static int CountNumbers(int key, int[] array)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (key == array[i])
            {
                counter++;
            }
        }
        return counter;
    }
}


using System;

class Loop
{
    private static void PrintUntilNumber<T>(T[] array, Predicate<int> predicate, T value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);

            if (predicate(i) && array[i].Equals(value))
            {
                Console.WriteLine("Value Found");
                break;
            }
        }
    }

    static void Main(string[] args)
    {
        int[] array = new int[2000];
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(20);
        }
        int value = 13;
        Predicate<int> predicate = i =>
                                       i % 10 == 0;
        PrintUntilNumber(array, predicate, value);
    }
}

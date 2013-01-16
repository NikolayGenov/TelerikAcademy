using System;

class MaxAndMinInSeq
{
    static void Main()
    {
        Console.WriteLine("Sequence of N numbers, where N is :");
        int n = int.Parse(Console.ReadLine());
        int max = 0, min = 0,temp;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter number [{0}/{1}]", i + 1, n);
            temp = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                max = temp;
                min = temp;
            }
            if (temp > max)
            {
                max = temp;
            }
            else if (temp < min)
            {
                min = temp;
            }
        }
        Console.WriteLine("The minimal value is : {0}\n and the maximum value is : {1}", min, max);
    }
}
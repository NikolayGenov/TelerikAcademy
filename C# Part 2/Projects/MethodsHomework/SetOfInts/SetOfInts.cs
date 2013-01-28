using System;

class SetOfInts
{
    static void Main()
    {
        //Predefined array 
        int[] arr = { 3, 5, 7, 8, 2, 1, 5, 6, -4, 5, 6, 7, 2, 553, 6 };
        //Print all the stuff passing the methods as formating param
        Console.WriteLine("The sum is : {0}", SumOfInts(arr));
        Console.WriteLine("The avg is : {0}", AvgOfInts(arr));
        Console.WriteLine("The max element is : {0}", MaxOfInts(arr));
        Console.WriteLine("The min element is : {0}", MinOfInts(arr));
    }

    private static int SumOfInts(int[] arr)
    {
        //Simple sum
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    private static double AvgOfInts(int[] arr)
    {
        //Using the previous method to calc avg of the number
        int sum = SumOfInts(arr);
        double avg = (double)sum / arr.Length;
        return avg;
    }

    private static int MaxOfInts(int[] arr)
    {
        //Find the max using build in compare
        int maxNumber = 0;
        int maxIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].CompareTo(arr[maxIndex]) > 0)
            {
                maxIndex = i;
            }
        }
        maxNumber = arr[maxIndex];
        return maxNumber;
    }
  
    private static int MinOfInts(int[] arr)
    {
        //Same but the other way around
        int minNumber = 0;
        int minIndex = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].CompareTo(arr[minIndex]) < 0)
            {
                minIndex = i;
            }
        }
        minNumber = arr[minIndex];
        return minNumber;
    }
}
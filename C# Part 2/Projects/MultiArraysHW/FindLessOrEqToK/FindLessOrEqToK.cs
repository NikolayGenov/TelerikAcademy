using System;

class FindLessOrEqToK
{
    static void Main(string[] args)
    {
        //User input for N and K
        Console.WriteLine("Enter N (array size):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        //Enter Numbers via method
        EnterArray(n, ref arr);
        //Sort the numbers
        Array.Sort(arr);
        //Geting the returning value of the search in int
        int value = Array.BinarySearch(arr, k);     
        
        if (value >= 0)
        {
            //If possitive - we have found K
            Console.WriteLine("The value = K is : {0}", arr[value]);
        }
        else
        {
            //If negative we do some transformations to get the new index or conclude there is no number less than K
            value += 2;
            value *= -1;
            if (value >= 0)
            {
                Console.WriteLine("The value < K is : {0}", arr[value]);
            }
            else
            {
                Console.WriteLine("No value in the array is less than or equal to K");
            }
        }
    }
  
    private static void EnterArray(int n, ref int[] arr)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("Array [{0}/{1}]= ", i + 1, n);
            arr[i] = int.Parse(Console.ReadLine());
        }
    }
}
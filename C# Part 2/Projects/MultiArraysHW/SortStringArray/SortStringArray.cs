using System;

class SortStringArray
{
    static void Main()
    {
        Console.WriteLine("Enter N (array size):");
        int n = int.Parse(Console.ReadLine());      
        string[] arr = new string[n];
        //Enter strings via method
        EnterArray(n, ref arr);
        //Sorting the array
        SortStrings(n, ref arr);
        //Print the result
        foreach (string item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    private static void SortStrings(int n, ref string[] arr)
    {
        //Using a ref we get arr and then use the method to get the lengths
        //Using them for keys we sort the 2 arrays and the out array is returned sorted by ref
        int[] arrKeys = GetLengths(n, arr);
        Array.Sort(arrKeys, arr);
    }
  
    private static int[] GetLengths(int n, string[] arr)
    {
        //Get the length of every string and save it in another array then return the array
        int[] arrLengths = new int[n];
        for (int i = 0; i < n; i++)
        {
            arrLengths[i] = arr[i].Length;
        }
        return arrLengths;
    }

    private static void EnterArray(int n, ref string[] arr)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("Array [{0}/{1}]= ", i + 1, n);
            arr[i] = Console.ReadLine();
        }
    }
}
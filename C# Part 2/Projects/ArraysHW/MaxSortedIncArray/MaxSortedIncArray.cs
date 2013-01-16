using System;
using System.Collections.Generic;

class MaxSortedIncArray
{
    static void Main()
    {
        //User input
        Console.WriteLine("Enter array size");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];
        //Filling the array with values
        for (int i = 0; i < size; i++)
        {
            Console.Write("Array [{0}/{1}]= ", i + 1, size);
            arr[i] = int.Parse(Console.ReadLine());
        }
        //Looping until 2 to the n-th-1 
        //We declare ints where we store the max length of increasing numbers
        long len = 2 << (size - 1);
        int maxInc = 0, inc = 0;
        //A list where we store the result
        List<int> result = new List<int>();
        
        for (int i = 1; i < len; i++)
        {
            //Create the gray code "mask" that we use to check the subsets
            int[] mask = new int[size];
            MakeMask(i, mask);
            //Here we make a method where we return the value of how many of those numbers are inc using the mask and the array we have
            inc = CheckIncreasing(arr, mask);
            //If there are more increasing numbers than the max found so far we store them in result which reuse a method from before
            if (inc > maxInc)
            {
                maxInc = inc;
                result = GetNumbersFromMask(arr, mask);
            }
        }
        //First we print the old array and then the new result with foreach 
        if (size > 0)
        {
            Console.Write("{ ");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.Write("} ---> { ");
            foreach (int item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("}");
        }
    }

    //Here we use as params the 2 arrays - mask and values array
    private static int CheckIncreasing(int[] arr, int[] mask)
    {
        int numberOfInc = 1;
        //We use method to make a list of only the values we want ( values with indexes same as those with 1 on the mask array) and collect them in one list
        List<int> numbs = GetNumbersFromMask(arr, mask);
        //A loop in the list  and check if its greater or equal to the next number in the list
        //if it's not it returns the current number of increasing numbers
        for (int i = 0; i < numbs.Count - 1; i++)
        {
            if (numbs[i] <= numbs[i + 1])
            {
                numberOfInc++;
            }
            else
            {
                return numberOfInc;
            }
        }//If they are all increasing it returns the number and later check with the maxIncreasing number of values
        return numberOfInc;
    }

    // We take the mask and array and loop
    //Where we have 1 in the mask array we add the value of the corresponding array to the list and then return the list
    private static List<int> GetNumbersFromMask(int[] arr, int[] mask)
    {
        List<int> numbs = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (mask[i] == 1)
            {
                numbs.Add(arr[i]);
            }
        }
        return numbs;
    }

    static void MakeMask(int pos, int[] mask)
    {
        //possition is the loop index from the first loop and it starts from 1 to 2 to the n-th -1
        //Just a representation of a number with only zeros and ones
        int i = 0;
        while (pos > 0)
        {
            mask[i] = pos % 2;
            pos /= 2;
            i++;
        }
    }
}


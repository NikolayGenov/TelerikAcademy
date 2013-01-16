using System;

class MaxSumSubset
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
        
        //Solving the problem with 1 cycle
        int sum = 0, result = int.MinValue;
        int firstIndex = 0, finalIndex = 0 ,index = 0;
        for (int i = 0; i < size; i++)
        {
            sum += arr[i]; //Collect the current sum in here
            if (sum > result) //if the sum is greater than the result it changes the indexes of the array part we take for max and result is equal to sum 
            {
                firstIndex = index;
                finalIndex = i;               
                result = sum;
            }
            if (sum < 0)
            {
                sum = 0;
                index = i + 1;
            }
        }
        if (size > 0)
        { //Formatin the string to look nice 
            Console.Write("max Sum ->{");
            for (int i = firstIndex; i <= finalIndex; i++)
            {
                if (i == finalIndex)
                {
                    Console.Write(arr[i]);
                }
                else
                {
                    Console.Write(arr[i] + ",");
                }
            }
            Console.Write("{0} = {1}", "}", result);
            Console.WriteLine();
        }
    }
}


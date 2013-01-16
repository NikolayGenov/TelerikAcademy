using System;

class SeqenceSumInArray
{
    static void Main()
    {
        //User input
        Console.WriteLine("Enter array size");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the sum S:");
        int S = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        //Filling the array with values
        for (int i = 0; i < size; i++)
        {
            Console.Write("Array [{0}/{1}]= ", i + 1, size);
            arr[i] = int.Parse(Console.ReadLine());
        }
        //Creating vars
        int tempSum = 0;
        int startIndex = 0, stopIndex = 0;
        bool found = false;
        //Looping in the array with 2 loops increasing and if we find the sum we break from the loops 
        for (int i = 0; i < size; i++)
        {
            tempSum = 0;
            for (int j = i; j < size; j++)
            {
                tempSum += arr[j];
                if (tempSum == S)
                {
                    startIndex = i;
                    stopIndex = j;
                    found = true;
                    break;
                }
            }
            if (found)
            {
                break;
            }
        }
        //If we have found such sum we print it 
        if (found)
        {   //Display the first found in the array
            Console.Write("Sequence ->{");
            for (int i = startIndex; i <= stopIndex; i++)
            {
                if (i == stopIndex)
                {
                    Console.Write(arr[i]);
                }
                else
                {
                    Console.Write(arr[i] + ",");
                }
            }
            Console.Write("{0} = {1}", "}", S);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("There isn't sequence that match the sum");
        }
    }
}


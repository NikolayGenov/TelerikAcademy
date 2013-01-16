using System;

class MostFrequentNumber
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
       //If the size is 0 there is no need to check
        if (size > 0)
        { //Sort the array;
            Array.Sort(arr);
            int item = arr[0], maxItem = arr[0], times = 1, maxTimes = 0; //Declaring the vars with the first value of the new sorted array
            for (int i = 0; i < size - 1; i++) 
            {
                if (arr[i] == arr[i + 1]) 
                    //looping in the array and checking if the 2 values are equal and if they are
                    //inc the times var with 1 and save it in another var
                {
                    times++;
                    item = arr[i];
                }
                else // if they are different make times equal to 1 again
                {
                    times = 1;
                }
                if (times > maxTimes) // if we have the same items 2 or more times there is a maxItem and MaxTimes were we save the result 
                {
                    maxItem = item;
                    maxTimes = times;
                }
            }
            //Print out the result
            Console.WriteLine("Most Frequent Item: {0}  Times : {1}", maxItem, maxTimes);
        }
    }
}


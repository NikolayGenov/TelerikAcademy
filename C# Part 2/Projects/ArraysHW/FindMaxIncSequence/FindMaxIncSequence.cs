using System;

class FindMaxIncSequence
{
    static void Main()
    {
        //Take user input
        Console.WriteLine("Enter array length");
        int arrayLength = int.Parse(Console.ReadLine());

        //Create the array and fill it with values
        int[] arr = new int[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            Console.WriteLine("Array [{0}/{1}]= ", i + 1, arrayLength);
            arr[i] = int.Parse(Console.ReadLine());
        }
      
        //Initialize some values - counter and maxCounter to keep tract of the count and vars for the value itself
        int counter = 1, maxCounter = 1, value, maxValue, index = 0;
        if (arrayLength > 0)
        {
            maxValue = arr[arrayLength - 1]; //if there isn't sequence longer than one it takes the last one
            value = arr[0];

            //For loop for the each step and if conditions to compare the values and if they are increasing then inc the counter and store the next value
            for (int i = 0; i < arrayLength - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    value = arr[i + 1];
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter >= maxCounter)
                {
                    index = i + 1;
                    maxValue = value;
                    maxCounter = counter;
                }
            }
            if (maxCounter > 1) // print if there is more than 2 numbers 
            {
                //Print out the result as a sequence
                //Takes the index from the array and print the numbers
                Console.Write("The max sequence is : ");
                for (int i = index - maxCounter + 1; i <= index; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There is less than 2 increasing numbers");
            }
        }
        else //in case the size is 0
        {
            Console.WriteLine("There is no array input because size is 0");
        }
    }
}
using System;

class ReadAndCompareArrays
{
    static void Main()
    {
        //Take the fist array user input
        Console.WriteLine("Enter first array length");
        int firstArrLength = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter each element from the first array");
       
        //Create the first array
        int[] firstArr = new int[firstArrLength];
        
        //Fill the first array
        for (int i = 0; i < firstArrLength; i++)
        {
            Console.Write("First Array [{0}/{1}]= ", i + 1, firstArrLength);
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        //Take the second array user input
        Console.WriteLine("Enter second array length");
        int secondArrLength = int.Parse(Console.ReadLine());
        if (firstArrLength != secondArrLength)
        {
            Console.WriteLine("The two arrays have different length!");
        }
        else
        {
            Console.WriteLine("Enter each element from the second array");
            //Create the first array
            int[] secondArr = new int[secondArrLength];
            for (int i = 0; i < secondArrLength; i++)
            {
                Console.Write("Second Array [{0}/{1}]= ", i + 1, secondArrLength);
                secondArr[i] = int.Parse(Console.ReadLine());
            }
            bool areEqual = true; 

            //Sorting the two arrays in order to have all the combinations
            Array.Sort(firstArr);
            Array.Sort(secondArr); 

            //Compare the arrays
            for (int i = 0; i < firstArrLength; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    areEqual = false;
                    break;
                }
            }
            //Print the result in case of the lengths are the same
            if (areEqual)
            {
                Console.WriteLine("The two arrays have the same values (might not be ordered by index values)");
            }
            else
            {
                Console.WriteLine("The two arrays have different values");
            }
        }
    }
}
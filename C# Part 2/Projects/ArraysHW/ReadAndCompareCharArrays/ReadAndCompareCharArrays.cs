using System;

class ReadAndCompareCharArrays
{
    static void Main()
    {
        //Take the fist array user input
        Console.WriteLine("Enter first array length");
        int firstArrLength = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter each char element from the first array");

        //Create the first array
        char[] firstArr = new char[firstArrLength];

        //Fill the first array
        for (int i = 0; i < firstArrLength; i++)
        {
            Console.Write("First Array [{0}/{1}]= ", i + 1, firstArrLength);
            firstArr[i] = char.Parse(Console.ReadLine());
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
            Console.WriteLine("Enter each char element from the second array");
            //Create the first array
            char[] secondArr = new char[secondArrLength];
            for (int i = 0; i < secondArrLength; i++)
            {
                Console.Write("Second Array [{0}/{1}]= ", i + 1, secondArrLength);
                secondArr[i] = char.Parse(Console.ReadLine());
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
            //Print the result in case of the lengths are the same and above 0
            if (firstArrLength != 0)
            {
                if (areEqual)
                {
                    Console.WriteLine("The two arrays are lexicographically the same(ignoring the order by index)");
                }
                else
                {
                    Console.WriteLine("The two arrays are NOT lexicographically the same");
                }
            }
        }
    }
}
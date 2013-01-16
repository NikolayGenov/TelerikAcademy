using System;

class CheckForSumOfSubset
{
    static void Main()
    {
        //User input
        Console.WriteLine("Enter array size");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Sum");
        int sum = int.Parse(Console.ReadLine());

        int[] arr = new int[size];
        //Filling the array with values
        for (int i = 0; i < size; i++)
        {
            Console.Write("Array [{0}/{1}]= ", i + 1, size);
            arr[i] = int.Parse(Console.ReadLine());
        }
        // we are looping until 2 to the n-th -1 and have var if we have found a matching sum of tempsum 
        long len = 2 << (size-1) ;
        int tempSum = 0;
        bool found = false;
        //Where we would put the values we will print
        int[] foundPossitions = new int[size];
        for (int i = 1; i < len; i++)
        {
            //Making "mask"
            int[] mask = new int[size];
            MakeMask(i, mask);//Parameters are the current possition and the array - Check below for more info
            for (int possition = 0; possition < size; possition++)
            {// we just multiply the possition of the array with 1 or 0 depends on the mask and add it to the sum
                tempSum += (arr[possition] * mask[possition]);
            }
            if (tempSum == sum) //If we find a sum that matches we break from the loop and save the possitions
            {
                foundPossitions = mask;
                found = true;
                break;
            }
            //reset the sum to 0 
            tempSum = 0;
        }
        if (found)
        { //Print if we have found a sum that matches
            Console.WriteLine();
            Console.Write("{ ");
            for (int i = 0; i < foundPossitions.Length; i++)
            {
                if (foundPossitions[i] == 1)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            Console.Write("{0} --> {1}", "}", sum);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("There is no values in the array which have sum of the sum that is given");
        }
    }
    /*We use the Gray code to represent the mask that later we multiply each value with the corresponding possition
     * for example if we have array of 5 numbers there are 31 combinations from zeros and ones
     * we can use as following
     * 00001
     * 00010
     * 00011
     * 00100
     * .....
     * 01011
     * .....
     * 11111
     * using those combinations with the array element at the given possition we can get any subset we want
     */
    static void MakeMask(int pos, int[] mask)
    {
        //possition is the loop index from the first loop and it starts from 1 to 2 to the n-th -1
        int i = 0;
        while (pos > 0)
        {
            mask[i] = pos % 2;
            pos /= 2;
            i++;
        }
    }
}


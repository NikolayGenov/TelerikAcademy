using System;
using System.Collections.Generic;

class SubsetOfKElemenetsWithSumS
{
    static void Main(string[] args)
    {
        //User Input for N, S and K
        Console.WriteLine("Enter array size N");
        int size = int.Parse(Console.ReadLine()); //N
        Console.WriteLine("Enter Sum S");
        int sum = int.Parse(Console.ReadLine()); //S
        Console.WriteLine("Enter number of subset elemenets K:");
        int k = int.Parse(Console.ReadLine());
        if ((k > size)||(k==0))
        {
            //We use that condition ot check if the array size is less than the numbers K we want to sum in the array or if the K is 0 as well as N(size)
            Console.WriteLine("We can't have N and K like those.");
        }
        else
        {
            int[] arr = new int[size];
            //Filling the array with values
            for (int i = 0; i < size; i++)
            {
                Console.Write("Array [{0}/{1}]= ", i + 1, size);
                arr[i] = int.Parse(Console.ReadLine());
            }
            // we are looping until 2 to the n-th -1 and have var if we have found a matching sum of tempsum 
            //but this time we will use K to compare if we have reached the number of elemenets given
            long len = 2 << (size-1);
            int tempSum = 0;
            bool found = false;
            int elemenetsCheckes = 0;
            //We will use list to save the numbers from the array with that sum we want
            List<int> subsetElemenets = new List<int>(size);
            for (int i = 1; i < len; i++)
            {
                //For temp sum of each iteration
                tempSum = 0;
                // Havint the possition of the element we add it if it matches the bitwise operation which moves the element and check if there is
                // one on the current possition and if it so it add it to the sum , to the list and inc the element counter 
                for (int pos = 0; pos < size; pos++)
                {
                    if ((1 & (i >> pos)) == 1)
                    {
                        tempSum += arr[pos];
                        subsetElemenets.Add(arr[pos]);
                        elemenetsCheckes++;
                    }
                }
                //Here it checks if the element have the matching sum and if there are exactly that many K elements we want 
                if ((tempSum == sum) && (elemenetsCheckes == k))
                {
                    found = true;
                    break;
                }
                else
                {
                    //In the other case we clear the list of the elements and set the counter of the elements to zero
                    subsetElemenets.Clear();
                    elemenetsCheckes = 0;
                }
            }
            if (found)
            {   //If we have found that kind of element we just print the result - else we say there isn't that K elemenets
                Console.Write("{ ");
                foreach (int item in subsetElemenets)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("{0} --> Sum = {1} --> {2} elements","}",sum,k);
            }
            else
            {
                Console.WriteLine("There is no K values in the array which have sum of the sum that is given");
            }
        }
    }
}


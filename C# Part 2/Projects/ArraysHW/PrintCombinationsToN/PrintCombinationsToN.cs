using System;

class PrintCombinationsToN
{
    static void Main()
    {
        //User Input
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        int[] combinations = new int[k]; // Where we would store the values we will print
        int index = 0;// Here its just a starting point
        int nextElement = 0;
        //Note - It for large numbers N and K it will take some time to print them ....
        CreateCombinations(index, combinations, k, n,nextElement);
    }

    //Recursive function to creat and print all the combinations
    //Pass as params all the values 
    private static void CreateCombinations(int index, int[] combinations, int k, int n,int nextElement)
    {
        //Bottom of the recursion where we print 
        if (index == k)
        { // when we get to the point where the index is matching the K number we print and then return to continue
            PrintOneCombination(combinations, k);
            return;
        }
        else
        {
            //Changing the index element where we put a nextElement where should print and simply add one to it becase it starts from 0 then again call recursivly
            for (int i = nextElement; i < n; i++)
            {
                combinations[index] = i+1;
                //Recursive call
                CreateCombinations(index + 1, combinations, k, n, i+1);
            }
        }
    }

    //Call it when we need to print the values of the array of K elements
    private static void PrintOneCombination(int[] combinations, int k)
    {
        //Print the values 
        Console.Write("{ ");
        for (int i = 0; i < k; i++)
        {
            if (i != k - 1) // we use it for the seperator
            {
                Console.Write(combinations[i] + ",");
            }
            else
            {
                Console.Write(combinations[i] + " ");
            }
        }
        Console.WriteLine("}");
    }
}


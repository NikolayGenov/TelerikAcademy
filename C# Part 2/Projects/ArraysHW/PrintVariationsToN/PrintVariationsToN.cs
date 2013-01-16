using System;

class PrintVariationsToN
{
    static void Main()
    {
        //User Input
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int k = int.Parse(Console.ReadLine());
        int[] variations = new int[k]; // Where we would store the values we will print
        int index = 0;// Here its just a starting point
        //Note - It for large numbers N and K it will take some time to print them ....
        CreateVariations(index, variations, k, n);
    }

    //Recursive function to creat and print all the variations
    //Pass as params all the values 
    private static void CreateVariations(int index, int[] variations, int k, int n)
    {
        //Bottom of the recursion where we print 
        if (index == k)
        { // when we get to the point where the index is matching the K number we print and then return to continue
            PrintOneVariation(variations, k);
            return;
        }
        else
        {
            //Changing the index element with each recursion and puttin a value in the array equal to i where it grows to N
            for (int i = 1; i <= n; i++)
            {
                variations[index] = i;
                //Recursive call
                CreateVariations(index + 1, variations, k, n);
            }
        }
    }

    //Call it when we need to print the values of the array of K elements
    private static void PrintOneVariation(int[] variations, int k)
    {
        //Print the values 
        Console.Write("{ ");
        for (int i = 0; i < k; i++)
        {
            if (i != k - 1) // we use it for the seperator
            {
                Console.Write(variations[i] + ",");
            }
            else
            {
                Console.Write(variations[i] + " ");
            }
        }
        Console.WriteLine("}");
    }
}


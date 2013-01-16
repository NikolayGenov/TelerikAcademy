using System;

class PrintPermutationsToN
{
    static void Main()
    {
        //User input
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        //Create the array and make a method to fill it with values we will swap later
        int[] permutations = new int[n];
        permutations = FillWithNumber(permutations);
        int index = 0;
        //Making method to create and print all the permutaions
        CreatePermutations(permutations, n, index);
    }
  
    private static int[] FillWithNumber(int[] permutations)
    {
        //Fill it with values from [1...n] and then return the array
        for (int i = 0; i < permutations.Length; i++)
        {
            permutations[i] = i + 1;
        }
        return permutations;
    }
  
    private static void CreatePermutations(int[] permutations, int n, int index)
    {
        //When we have the index value equal to the numbers we print every time with recursive calls
        if (index == n)
        {
            PrintOnePermutation(permutations, n);
        }
        else
        {
            //Looping from index to n
            for (int i = index; i < n; i++)
            {
                //Making our own method to  swap 2 values with ref so we will change them in the array
                SwapTwoValues(ref permutations[index], ref permutations[i]);               
                CreatePermutations(permutations, n, index + 1); // recursive calls
                SwapTwoValues(ref permutations[index], ref permutations[i]);
            }
        }
    }

    private static void SwapTwoValues(ref int p1, ref int p2)
    { // simple swap with ref
        int temp = p2;
        p2 = p1;
        p1 = temp;
    }
  
    private static void PrintOnePermutation(int[] permutations, int n)
    {
        //Print the values 
        Console.Write("{ ");
        for (int i = 0; i < n; i++)
        {
            if (i != n - 1) // we use it for the seperator
            {
                Console.Write(permutations[i] + ",");
            }
            else
            {
                Console.Write(permutations[i] + " ");
            }
        }
        Console.WriteLine("}");
    }
}


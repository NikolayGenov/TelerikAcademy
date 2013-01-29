using System;
using System.Collections.Generic;

class CalcTheSum
{
    static void Main()
    {   /*
         * Read the comments (in the method) bellow if you want to test with a given string
         */

        //Use a list we we would store the values
        List<int> numList = new List<int>();
        GetInput(ref numList);
        int sum = 0;
        //adding to a sum all the items in the list
        foreach (int item in numList)
        {
            sum += item;
        }
        Console.WriteLine("The sum of the sequence is {0}", sum);
    }
  
    private static void GetInput(ref List<int> numList)
    { 
        //For the sequence 
        //If you want to give a string and not enter it everytime UNCOMMENT those lines marked with  '<----' and comment those with 'X'
        string seq;//                                                        X
        // string seq = "3 4 6 8 3 4 5 78 4 123";                         <----
         
        //Checking if the sequence is empty and if it is repeat until there is something and that something is number
        do
        {
            Console.WriteLine("Enter a sequence : (seperated with space)");// X
            seq = Console.ReadLine();//                                       X
            if (seq.Length != 0)
            {
                string[] arr = seq.Split(' ');
                for (int i = 0; i < arr.Length; i++)
                {
                    numList.Add(int.Parse(arr[i]));
                }
            }
        }
        while (numList.Count == 0);
    }
}
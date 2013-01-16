using System;

class CreateModifySimpleArray
{
    static void Main()
    {
        //Allocates the array
        int[] arr = new int[20];

        //Going through the array and printing the values
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i * 5;
            Console.WriteLine("Array [{0}] = {1}",i,arr[i]);
        }
    }
}

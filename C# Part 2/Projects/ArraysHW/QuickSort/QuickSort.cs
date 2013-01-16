using System;

class QuickSort
{
    static void Main()
    {
        //User input
        Console.WriteLine("Enter array size");

        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter STRING values");
        string[] arr = new string[size];
        //Filling the array with values
        for (int i = 0; i < size; i++)
        {
            Console.Write("Array [{0}/{1}]= ", i + 1, size);
            arr[i] = Console.ReadLine();
        }
        //put parameters as the starting point 0 and the end of the array
        //Sorting the array in lexicographical order
        QuickSorting(arr, 0, size - 1);
        //Print out the sorted string array
        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i] + " ");
            
        }
        Console.WriteLine();
    }

    // The params are actually the left and the right side of the part we are currently using
    private static void QuickSorting(string[] arr, int left, int right)
    {
        int leftRecCall= left;
        int rightRecCall = right;
        //Set the pivot point we are comparing with
        string pivot = arr[(left + (right-left)/2)];
        while (left <= right)
        { 
            //Compare the left side of the array to the pivot point  (CompareTo returns integer value (-1 if its less and possitive integer if greater , and 0 if equal))
            while (arr[left].CompareTo(pivot) < 0)
            {
                left++;
            }
            //we do the same thing for the right side
            while (arr[right].CompareTo(pivot) > 0)
            {
                right--;
            }
            if (left <= right)
            { //We swap the two elements the left one with the right one
                string temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                
                //And inc the left with 1 and dec the right with 1
                left++;
                right--;
            }
        }

        //Make the recursive calls until we are done with the cases 
        if (leftRecCall<right)
        {
            QuickSorting(arr, leftRecCall, right);
        }
        if (left<rightRecCall)
        {
            QuickSorting(arr, left, rightRecCall);
        }

    }
}


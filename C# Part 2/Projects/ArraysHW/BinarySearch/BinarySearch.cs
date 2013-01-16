using System;

class BinarySearch
{
    static void Main()
    {
        //User input
        Console.WriteLine("Enter array size");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("The element we are seaching for");
        int element = int.Parse(Console.ReadLine());
       
        int[] arr = new int[size];
        //Filling the array with values
        for (int i = 0; i < size; i++)
        {
            Console.Write("Array [{0}/{1}]= ", i + 1, size);
            arr[i] = int.Parse(Console.ReadLine());
        }
        //Sorting the array if not sorted already
        Array.Sort(arr);
        int index = BinSearch(arr, element, size); //Return the index of the element in the array
        if (index==-1) //Check if its found
        {
            Console.WriteLine("{0} is not found in the array",element);
        }
        else
        {
            Console.WriteLine("{0} is found on the '{1}' index possition in the sorted array",element,index);
        }
    }
    
    private static int BinSearch(int[] arr, int element,int size)
    {   //We should move only between min and max where max is the size of the array-1 (those are index values)
        int min = 0, max = size - 1, mid = 0;
        while (max >= min)
        {//Looping until we find the first occurrence
            mid = min + (max - min) / 2; //Changing the mid point every
            if (element == arr[mid])
            {   //if the element is found return it
                return mid;

            }
            else if (element<arr[mid]) //if its not found going in the part of the array where it could be found
            {   
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }

        }
        //If not found return -1 
        return -1;
    }
}


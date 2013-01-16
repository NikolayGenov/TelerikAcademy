using System;

class MergeSort
{
    static void Main()
    {
        //User input
        Console.WriteLine("Enter array size");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];
        //Filling the array with values
        for (int i = 0; i < size; i++)
        {
            Console.Write("Array [{0}/{1}]= ", i + 1, size);
            arr[i] = int.Parse(Console.ReadLine());
        }
        //Merge sort method
        arr = MergeSorting(arr);
        //Just printing out the sorded array of ints
        if (size > 0)
        {
            Console.WriteLine("Sorted array:");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    //Use recursivly calling algorithm and when it goes back it merges the element in the way we want to be ordered
    private static int[] MergeSorting(int[] arr)
    {
        //If the array have only 1 or 0 elements its sorted already
        if (arr.Length <= 1)
        {
            return arr;
        }
        //Take the middle point every time we go in the method over and over again
        int middle = (arr.Length / 2);
        //Creating left and right arrays where we put the values from the begining and calling the function once again
        int[] left = new int[middle];
        int[] right = new int[arr.Length - middle];
        // Filling them with the values from the array which changes every time which each recursive call
        for (int i = 0; i < middle; i++)
        {
            left[i] = arr[i];
        }
        for (int i = 0; i < arr.Length - middle; i++)
        {
            right[i] = arr[i + middle];
        }
        //Making recursive calling of the fucntions until it reaches the bottom
        left = MergeSorting(left);
        right = MergeSorting(right);
        //Then process make a new sorted array and start to fill it with the values from the left and right arrays using checks for the indexes
        //It goes over and over again untill its done with the recursive calling
        int rightIndex = 0, leftIndex = 0;
        int[] sortedArray = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        { // For the second condition we use a little trick
            // We have that OR operator and we first check the index and if it return false 
            // The AND operator returns false right away because in the other case it throws index out of range exception
            if ((rightIndex == right.Length) || ((leftIndex < left.Length) && (left[leftIndex] <= right[rightIndex])))
            {
                sortedArray[i] = left[leftIndex];
                leftIndex++;
            }//We use the same trick here
            else if ((leftIndex == left.Length) || ((rightIndex < right.Length) && (right[rightIndex] <= left[leftIndex])))
            {
                sortedArray[i] = right[rightIndex];
                rightIndex++;
            }
        }
        // In the end it returns the ordered array
        return sortedArray;
    }
}

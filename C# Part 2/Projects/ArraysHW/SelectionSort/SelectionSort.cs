using System;

class SelectionSort
{
    static void Main(string[] args)
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
        int minIndex, temp;
        
        //Selection sort
        for (int i = 0; i < size - 1; i++) 
        {
            minIndex = i; //Taking the index of the element and the comparing with the next
                
            for (int j = i + 1; j < size; j++)
            {
                //If we find a smaller element we asign it to minIndex
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            //If we have found a smaller we just swap the two values 
            if (minIndex != i)
            {
                temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        //Printing the result with foreach
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}


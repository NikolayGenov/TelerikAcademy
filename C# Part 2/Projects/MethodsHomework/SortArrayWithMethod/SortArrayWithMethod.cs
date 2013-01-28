using System;

class SortArrayWithMethod
{
    static void Main()
    {
        //predefined array
        int[] array = { 4, 5, 6, 7, 8, 4, 15, 67, 2, 1, 7, 8, 4, 2, 3, 4, 8, 4, 3, 54, 1, 8, 4, 6, 8, 9, -4, 6661, 3, 431, 5, 6 };
        //sort the array
        SortArray(ref array);
        //Print the result
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        ;
    }
  
    private static void SortArray(ref int[] array)
    {
        int index;
        int len = array.Length;
        //Loop untill the end of the array and takes the index using the other method and then swap the 2 values
        for (int i = 0; i < array.Length; i++)
        {
            index = FindMaxInPart(array, len);
          
            //Use that var to keep track were we have sorted tha array already and not to bother those elements
            len = array.Length - 1 - i;
            Swap(index, len, ref array);
        }
    }
  
    private static void Swap(int index, int len, ref int[] array)
    { 
        //Simple swap method
        int temp = array[len];
        array[len] = array[index];
        array[index] = temp;
    }
  
    private static int FindMaxInPart(int[] array, int len)
    {
        //We are given index and we take the max element in that part and return its index
        int temp = array[0];
        int tempIndex = 0;
        for (int i = 0; i < len; i++)
        {
            if (array[i] > temp)
            {
                temp = array[i];
                tempIndex = i;
            }
        }
        return tempIndex;
    }
}
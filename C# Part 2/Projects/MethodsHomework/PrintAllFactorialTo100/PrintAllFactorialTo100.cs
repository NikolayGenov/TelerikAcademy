using System;

class PrintAllFactorialTo100
{
    static void Main()
    {
        for (int i = 1; i < 101; i++)
        {
            //Where we store the number
            int [] arr =  new  int [150];
            //Turn the i to array of numbers
            NumberToArray(i,ref arr);
            for (int j = 1; j < i; j++)
            {
                //multiply the numbers
               MultiplyNumbers(j, ref arr);
            }
            //Print the result
            PrintResult(i, arr);
        }
    }
  
    private static void PrintResult(int i, int[] arr)
    {
        //Print the result 
        //Avoid printing the zeros in the begining
        bool print = false;
        Console.Write("{0} : ", i);
        for (int k = arr.Length - 1; k >= 0; k--)
        {
            if (arr[k]!=0)
            {
                print = true;  
            }
            if (print)
            {
                Console.Write("{0}", arr[k]);
            }
          
        }
        Console.WriteLine();
    }
  
    private static void MultiplyNumbers(int j, ref int[] arr)
    {
        //Multiply every possition with j
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = arr[i] * j;
        }
        //If the number is more than 9 we increase the next
        for (int i = 0; i < arr.Length-1; i++)
        {
            int temp = arr[i] / 10;
            arr[i+1] += temp;
            arr[i] %= 10;
        }
    }

    private static void NumberToArray(int number,ref int[] arr)
    {
        //Turn the number to array of ints
        int i = 0;
        while (number > 9)
        {
            arr[i]=(number % 10);
            number /= 10;
            i++;
        }
        arr[i]=(number % 10);
        return ;
    }
}
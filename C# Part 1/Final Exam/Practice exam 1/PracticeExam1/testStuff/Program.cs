using System;



class Program
{
    static void Main()
    {
        byte[] matrix = new byte[8];
        byte[] countMat = new byte[8];
        for (int i = 0; i < matrix.Length; i++)
        {

           byte temp = byte.Parse(Console.ReadLine());
           matrix[i] = temp;
         }
        //collecting the info   
        for (int i = 0; i < matrix.Length; i++)
        {
            byte temp = matrix[i];
            for (int j = 0; j < matrix.Length; j++)
            {
                if ((temp & 1) == 1) 
                {
                    countMat[j]++;

                }
                temp >>= 1;

            }
        }
        //making the numbers
        for (int i = 0; i < matrix.Length; i++)
        {
            byte sum = 0;
            
            byte mask = 1;
            for (int j = 0; j < matrix.Length; j++)
            {
                if (countMat[j] > 0)
                {
                    sum += mask;
                    countMat[j]--;
                 }
                mask <<= 1;
            }
            matrix[matrix.Length - i-1] = sum;  
        }
        foreach (byte number in matrix)
        {
            Console.WriteLine(number);
        }
    }

    
}


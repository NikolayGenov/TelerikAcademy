using System;

class PrintMatrix4
{
    static void Main()
    {
        //Takes user info and create the array
        Console.WriteLine("Enter n:");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        //Make some vars to use in the while loop
        int currentLength = n;
        int value = 1;
        int numberOfCells = n * n; //We loop until we reach the max value
        int row = -1, col = 0; 
        int direction = 1; //We use that var to keep track of our value and every 2 for loops we change it
        //Start the loop 
        while (value < numberOfCells + 1)
        {
            //Prints the rows
            for (int i = 0; i < currentLength; i++)
            {
                row += direction; // when direction is +  we get down from 0 to n , when (-) we print then the from upside down  
                arr[row, col] = value;
                value++;
            }
            --currentLength; //changing the length of what we will print
            for (int j = 0; j < currentLength; j++)
            {
                //Print the cols from left to right and the other way around
                col += direction;
                arr[row, col] = value;
                value++;
            }
            direction *= -1;//changing the direction with * (-1)
        }
        //Print the matrix on the console
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3} ", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}
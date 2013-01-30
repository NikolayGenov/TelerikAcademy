using System;
using System.Collections.Generic;

class EqualNeighborsProblem
{
    static readonly int magicNumber = -42;

    static void Main()
    {
        //Change the matrix if you like to test
        int[,] matrix =
        {
            { 1, 3, 2, 2, 2, 4 },
            { 3, 3, 3, 2, 4, 4 },
            { 4, 3, 1, 2, 3, 3 },
            { 4, 3, 1, 3, 3, 1 },
            { 4, 3, 3, 3, 1, 1 }
        };
        //some vars to keep the count
        int counter = 0, maxCount = 0;
        //Loop in the matrix- for every element we make a path and get the length of that path in the end
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                //Not to go where we have been
                if (matrix[row, col] != magicNumber)
                {
                    //using list because of some build-in options
                    List<int> path = new List<int>();    
                    //Using recursion to do depth-first search
                    DepthSearch(row, col, ref path, matrix);
                    //Get and compare the size of our path
                    counter = path.Count;
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                    }
                }
            }
        }
        //Print the result
        Console.WriteLine("Largest area of equal elemenets is {0}", maxCount);
    }
  
    private static void DepthSearch(int row, int col, ref List<int> path, int[,] matrix)
    { //Check if our element will be out of the matrix
        if (!CanWeGoThere(row, col, matrix))
        {
            return;
        }
        int element = matrix[row, col];
        //Make the path- if its zero we add the first elemenent  and then we check if the next elemenets are the same as the first
        if (path.Count != 0 && !path.Contains(element))
        {
            return;
        }
        else
        {
            //If they are we add them
            path.Add(element);
        }
        //Set that we have visited that element
        matrix[row, col] = magicNumber;
        //Going in each direction with recursive calls
        DepthSearch(row, col - 1, ref path, matrix); //Left
        DepthSearch(row - 1, col, ref path, matrix); //Up
        DepthSearch(row, col + 1, ref path, matrix); //Right
        DepthSearch(row + 1, col, ref path, matrix); //Down
    }

    //Check if the element will be inside of the matrix borders and return a bool value
    private static bool CanWeGoThere(int row, int col, int[,] matrix)
    {
        if ((row >= 0) && (col >= 0) && (row < matrix.GetLength(0)) && (col < matrix.GetLength(1))) 
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
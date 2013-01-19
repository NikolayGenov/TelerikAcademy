using System;
using System.Collections.Generic;

class SequencesInMatrix
{
    static void Main()
    {
        //User input for the rows and cols
        Console.WriteLine("Enter N (rows):");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter M (cols)");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];
        //Method to enter all the strings
        EnterNumbers(n, m, ref matrix);
        
        //We declare a list where we should output the result at the end
        List<string> maxSeq = new List<string>();
        //Create and use a method to return as a result that list
        maxSeq = LongestSeq(n, m, matrix);
        //Print the list
        foreach (string item in maxSeq)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    private static void EnterNumbers(int n, int m, ref string[,] matrix)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Matrix [{0}/{1},{2}/{3}]= ", i + 1, n, j + 1, m);
                matrix[i, j] = Console.ReadLine();
            }
        }
    }

    private static List<string> LongestSeq(int n, int m, string[,] matrix)
    {
        //Use 1 temp and one list to return the result
        List<string> tempList = new List<string>();
        List<string> maxList = new List<string>();

        //Looping for each value in the array   
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                //For each iteration we check the row , the col and the diagonal 
                //And then compare it with the max result so far
                tempList = CheckRow(i, j, matrix);               
                CompareLists(ref tempList, ref maxList);
                tempList = CheckCol(i, j, matrix);
                CompareLists(ref tempList, ref maxList);
                tempList = CheckDiagonal(i, j, matrix);
                CompareLists(ref tempList, ref maxList);
            }
        }
        //return the result
        return maxList;
    }

    private static List<string> CheckRow(int i, int j, string[,] matrix)
    {
        //Use a temp list where we store the output
        
        List<string> rows = new List<string>();
        //Add the member we are checking 
        rows.Add(matrix[i, j]);

        for (int row = j; row < matrix.GetLength(1) - 1; row++)
        {
            //Check if the string we are checking is the same with the next in the row
            if (matrix[i, row] == matrix[i, row + 1])
            {
                //If so we add it to the list
                rows.Add(matrix[i, row]);
            }
            else
            {
                break;
            }
        }
        //Return the row for further operations
        return rows;
    }

    private static List<string> CheckCol(int i, int j, string[,] matrix)
    {
        //We do the same thing for cols but this time we check the cols
        List<string> cols = new List<string>();
        cols.Add(matrix[i, j]);
        for (int col = i; col < matrix.GetLength(0) - 1; col++)
        {
            if (matrix[col, j] == matrix[col + 1, j])
            {
                cols.Add(matrix[col, j]);
            }
            else
            {
                break;
            }
        }
        return cols;
    }
  
    private static List<string> CheckDiagonal(int i, int j, string[,] matrix)
    {
        //And the same thing for diagonals but this time we loop in a different way
        List<string> diagonal = new List<string>();
        diagonal.Add(matrix[i, j]);
        for (int col = i, row = j; ((col < matrix.GetLength(0) - 1) && (row < matrix.GetLength(1) - 1)); row++, col++)
        {
            if (matrix[col, row] == matrix[col + 1, row + 1])
            {
                diagonal.Add(matrix[col, row]);
            }
            else
            {
                break;
            }
        }
        return diagonal;
    }
    
    private static void CompareLists(ref List<string> tempList, ref List<string> maxList)
    {
        //Here we take the ref of the list and if we find a temp list with more members than
        //the max so far we clean the max and add it to it . Both ways we clean the temp
        //No need to return because we use ref
        if (tempList.Count > maxList.Count)
        {
            maxList.Clear();
            maxList.AddRange(tempList);
            tempList.Clear();
        }
        else
        {
            tempList.Clear();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

class SevenSegmentDisplay
{
    static int rows;
    static int[,] numbers = new int[,]
    {
        { 1, 1, 1, 1, 1, 1, 0 },
        { 0, 1, 1, 0, 0, 0, 0 },
        { 1, 1, 0, 1, 1, 0, 1 },
        { 1, 1, 1, 1, 0, 0, 1 },
        { 0, 1, 1, 0, 0, 1, 1 },
        { 1, 0, 1, 1, 0, 1, 1 },
        { 1, 0, 1, 1, 1, 1, 1 },
        { 1, 1, 1, 0, 0, 0, 0 },
        { 1, 1, 1, 1, 1, 1, 1 },
        { 1, 1, 1, 1, 0, 1, 1 }
    };         

    static void Main()
    {
       PrintNumbers( GetNumbers(UserInput()));
    }

    private static void PrintNumbers(List<List<int>> list)
    {
        List<int> nest = new List<int>();
       int k =0;
        foreach (List<int>  nested in list)
        {
            for (int i = 0; i < nested.Count; i++)
            {
                
            }
        }
    }
  
   
    
  
    private static List<List<int>> GetNumbers(int[,] userInput)
    {
       List<List<int>> result = new List<List<int>>();
      
        for (int i = 0; i < rows; i++)
        { // za vseski red
            List<int> possibleForRow = new List<int>();
            for (int k = 0; k < 10; k++)
            {
                bool isValid = true;
                for (int j = 0; j < 7; j++)
                {
                    if ((userInput[i, j] == 1) & (numbers[k, j] == 1))
                    {
                        continue;
                    }
                    else if (userInput[i, j] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid&&!possibleForRow.Contains(k))
                {

                    possibleForRow.Add(k);
                }
            }
            
                result.Add(possibleForRow);
			
        }
        return result;
    }
  
    private static int[,] UserInput()
    {
        rows = int.Parse(Console.ReadLine());
        int[,] inputNumbers = new int[rows, 7];
        for (int i = 0; i < rows; i++)
        {
            string temp = Console.ReadLine();
            char[] temp1 = temp.ToCharArray();
            for (int j = 0; j < 7; j++)
            {
                inputNumbers[i, j] = int.Parse(temp1[j].ToString());
            }
        }
        return inputNumbers;
    }
}
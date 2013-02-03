using System;

class CheckBrackets
{
    static void Main()
    {
        //User input
        Console.WriteLine("Enter a string");
        string input = Console.ReadLine();
        //Create the result string depending on the result if it is correct or not and then prin the result
        string result = IsCorrect(input) ? "This expression is correct!" : "This expression is NOT correct!";
        Console.WriteLine(result);
    }
    
    private static bool IsCorrect(string input)
    {
        //Make a buffer to save the number of '(' and ')' combined
        int buffer = 0;
        for (int i = 0; i < input.Length; i++)
        {
            //If at any point the buffer is less than 0 - > the ) are more than '(' - is is not correct
            if (buffer < 0)
            {
                return false;
            }
            //Add and remove from the buffer
            if (input[i] == '(')
                buffer++;
            if (input[i] == ')')
                buffer--;
        }
        //If the buffer is a number different than 0 - is is incorrect
        return buffer == 0 ? true : false;
    }
}
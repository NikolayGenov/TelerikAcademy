using System;

class CountSubstring
{
    static void Main()
    {
        //Some input to test the program
        string input = @"We are living in an yellow submarine.
                        We don't have anything else. Inside the submarine is very tight.
                        So we are drinking all the day. We will move out of it in 5 days.";
        //To find all lower and uppercase occurrences of the key word
        input = input.ToLower();
        string keyWord = "in";
        int position = -1;
        int counter = 0;
        //Loop until we can't find it anymore
        while (input.IndexOf(keyWord, position + 1) != -1) 
        {
            //When we find it we save the position and add to the counter
            position = input.IndexOf(keyWord, position + 1);
            counter++;
        }
        Console.WriteLine("The word '{0}' can be found in the text {1} times", keyWord, counter);
    }
}
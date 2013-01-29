using System;

class TestProblem
{
    static void Main()
    {
        Console.WriteLine("Enter a number ");
        //We multiply by 10
        int mult = 11;
        long sum = 1;
        for (int i = 0; i < mult; i++)
        {
            sum *= mult;
            
        }
        Console.WriteLine(sum);

        //Create a loop to add +1 to the sum mult times

        for (int i = 0; i < mult; i++)
        {
            sum += 111;
        }
        for (int i = 0; i < mult; i++)
        {
            sum /= 5;
        }
        Console.WriteLine(sum);
    }
}

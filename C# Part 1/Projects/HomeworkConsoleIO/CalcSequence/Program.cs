using System;

class CalcSequence
{
    static void Main()
    {
        double sum = 1, nextMember = 1; //Define where we would keep the sum and the next member of the seq
        int i = 2; 
        while (nextMember > 0.001) //Check for the cond and do it while it turn false
        {
            nextMember = 1.0 / i; // Finding the next member
            if ((i % 2) == 0)
            {
                sum += nextMember; //adds if it's even
            }
            else
            {
                sum -= nextMember; //subtracts if it's odd
            }
            i++; 
        }
        Console.WriteLine("The sum is : {0:0.000}",sum); //Print it with 0.000 format
    }
}


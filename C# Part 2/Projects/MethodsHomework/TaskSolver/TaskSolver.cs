using System;
using System.Collections.Generic;

class TaskSolver
{
    static void Main()
    {
        //Use the retuned value of the PickATask method for the switch (its valid )
        int task = PickATask();
        switch (task)
        {
            case 1:
                ReverseDigits();
                break;
            case 2:
                CalculateAverage();
                break;
            case 3:
                SolveEquation();
                break;
        }
    }
  
    private static void ReverseDigits()
    {
        //validation a number that is greater than 0 with do while
        int number = 0;
        do
        {
            Console.WriteLine("Enter a number > 0 :");
            number = int.Parse(Console.ReadLine());
        }
        while (number < 0);
        //Print the reversed number
        Console.WriteLine("The reversed number is:");
        while (number > 9)
        {
            Console.Write(number % 10);
            number /= 10;
        }
        Console.WriteLine(number % 10);
        return;
    }
  
    private static void CalculateAverage()
    {
        //Use a list we we would store the ints
        List<int> numList = new List<int>();
        string seq;
        //Checking if the sequence is empty and if it is repeat until there is something and that something is number
        do
        {
            Console.WriteLine("Enter a sequence : (seperated with space)");
            seq = Console.ReadLine();
            if (seq.Length != 0)
            {
                string[] arr = seq.Split(' ');
                for (int i = 0; i < arr.Length; i++)
                {
                    numList.Add(int.Parse(arr[i]));
                }
            }
        }
        while (numList.Count == 0);
        int sum = 0;
        //adding to a sum all the items in the list
        foreach (int item in numList)
        {
            sum += item;
        }
        //Calctulate and print the result
        double avg = (double)sum / numList.Count;
        Console.WriteLine("The average of the sequence is {0}", avg);
        return;
    }
  
    private static void SolveEquation()
    {
        int a = 0, b = 0;        
        Console.WriteLine("Enter coefficients a and b for equation like 'a*x + b = 0'");

        //Validating the output with do /while
        do
        { 
            Console.WriteLine("Enter a: ");
            a = int.Parse(Console.ReadLine());
        }
        while (a == 0);
        Console.WriteLine("Enter b: ");
        b = int.Parse(Console.ReadLine());
        //Calculate and print x
        double x = ((-b) / (double)a);
        Console.WriteLine("x = {0}", x);
        return;
    }
  
    private static int PickATask()
    {
        //User read and pick one of those tasks. The user will be ask to pick a task until he got a number from 1 to 3 right
        Console.WriteLine("For reversing digits of number : PRESS 1 and Enter");
        Console.WriteLine("For calculating the average of a sequence :  PRESS 2 and Enter");
        Console.WriteLine("For solving Linear equation a*x +b = 0 : PRESS 3 and Enter");
        int task = 0;
        do
        {
            Console.WriteLine("Pick a number (1-3) : ");
            task = int.Parse(Console.ReadLine());
        }
        while (!(task <= 3 && task >= 1));
        //return the task int
        return task;
    }
}
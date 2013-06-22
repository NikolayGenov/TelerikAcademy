using System;
using System.Numerics;

class FibonacciSequence
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
        BigInteger sumOfNumbers = 0, totalSum = 0;
        BigInteger firstNum = 0, secondNum = 1;

        for (int i = 1; i < n; i++)
        {
            firstNum = secondNum;
            secondNum = sumOfNumbers;
            sumOfNumbers = firstNum + secondNum;
            totalSum += sumOfNumbers;
        }
        Console.WriteLine("For N={0} the sum of the Fibonacci sequence is\n{1}", n, totalSum);
    }
}
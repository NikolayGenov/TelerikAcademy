using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        int sumOfNNumbers = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter number {0}",i+1);
            int number = int.Parse(Console.ReadLine());
            sumOfNNumbers += number;     
        }
        Console.WriteLine("The sum of those {0} numbers is : {1}",n,sumOfNNumbers);
   
    }
   

}


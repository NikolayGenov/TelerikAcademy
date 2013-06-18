using System;

class NFacDivKFac
{
    static void Main()
    {
        Console.WriteLine("Enter K:(K<N)");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter N:");
        int n = int.Parse(Console.ReadLine());
    
        long sum = 1;
        if ((k<n)&&(k>1))
        {
            //Think of optimization to calculate only (k+1).(k+2)....(n-1).(n)
            for (int i = k+1; i <= n; i++)
            {
                sum *= i;
            }
            Console.WriteLine("The sum of N!/K! is: {0}",sum);
        }
        else
        {
            Console.WriteLine("ERROR");
        }

    }
}


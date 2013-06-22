using System;
using System.Diagnostics;

namespace PerfomanceTypes
{
    class TestTypes
    {
        public const int COUNT = 30000000;
                                 
        public delegate void Delegate<T>();
       
        public static void DisplayTime<T>(Delegate<T> action)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static void Add<T>() 
        {
            T valueOne = (dynamic)3;
            T valueTwo = (dynamic)3;
            T sumForOneIteration = valueOne;
            for (int i = 0; i < COUNT; i++)
            {
                sumForOneIteration = (dynamic)valueOne + valueTwo;
            }
        }

        public static void Sub<T>()
        {
            T valueOne = (dynamic)4;
            T valueTwo = (dynamic)3;
            T sumForOneIteration = valueOne;
            for (int i = 0; i < COUNT; i++)
            {
                sumForOneIteration = (dynamic)valueOne - valueTwo;
            }
        }

        public static void Increment<T>()
        {
            T value = (dynamic)(1);
            for (int i = 0; i < COUNT; i++)
            {
                value = (dynamic)value + 1;
            }
        }

        public static void Miltiply<T>()
        {
            T valueOne = (dynamic)4;
            T valueTwo = (dynamic)3;
            T sumForOneIteration = valueOne;
            for (int i = 0; i < COUNT; i++)
            {
                sumForOneIteration = (dynamic)valueOne * valueTwo;
            }
        }

        public static void Divide<T>()
        {
            T valueOne = (dynamic)4;
            T valueTwo = (dynamic)3;
            T sumForOneIteration = valueOne;
            for (int i = 0; i < COUNT; i++)
            {
                sumForOneIteration = (dynamic)valueOne / valueTwo;
            }
        }

        static void Main(string[] args)
        {
            //TO LOAD THE STATIC functions
            Console.WriteLine("INITIALISATION");
            DisplayTime<int>(Add<int>);
            //Ignore that result
            Console.WriteLine();

            Console.WriteLine("FOR INT");
            Console.Write("Add: ");
            DisplayTime<int>(Add<int>);
            Console.Write("Sub: ");
            DisplayTime<int>(Sub<int>);           
            Console.Write("Inc: ");
            DisplayTime<int>(Increment<int>);
            Console.Write("Mult: ");
            DisplayTime<int>(Miltiply<int>);
            Console.Write("Div: ");
            DisplayTime<int>(Divide<int>);

            Console.WriteLine("\nFOR LONG");
            Console.Write("Add: ");
            DisplayTime<long>(Add<long>);
            Console.Write("Sub: ");
            DisplayTime<long>(Sub<long>);
            Console.Write("Inc: ");
            DisplayTime<long>(Increment<long>);
            Console.Write("Mult: ");
            DisplayTime<long>(Miltiply<long>);
            Console.Write("Div: ");
            DisplayTime<long>(Divide<long>);

            Console.WriteLine("\nFOR FLOAT");
            Console.Write("Add: ");
            DisplayTime<float>(Add<float>);
            Console.Write("Sub: ");
            DisplayTime<float>(Sub<float>);
            Console.Write("Inc: ");
            DisplayTime<float>(Increment<float>);
            Console.Write("Mult: ");
            DisplayTime<float>(Miltiply<float>);
            Console.Write("Div: ");
            DisplayTime<float>(Divide<float>);

            Console.WriteLine("\nFOR DOUBLE");
            Console.Write("Add: ");
            DisplayTime<double>(Add<double>);
            Console.Write("Sub: ");
            DisplayTime<double>(Sub<double>);
            Console.Write("Inc: ");
            DisplayTime<double>(Increment<double>);
            Console.Write("Mult: ");
            DisplayTime<double>(Miltiply<double>);
            Console.Write("Div: ");
            DisplayTime<double>(Divide<double>);

            Console.WriteLine("\nFOR DECIMAL");
            Console.Write("Add: ");
            DisplayTime<decimal>(Add<decimal>);
            Console.Write("Sub: ");
            DisplayTime<decimal>(Sub<decimal>);
            Console.Write("Inc: ");
            DisplayTime<decimal>(Increment<decimal>);
            Console.Write("Mult: ");
            DisplayTime<decimal>(Miltiply<decimal>);
            Console.Write("Div: ");
            DisplayTime<decimal>(Divide<decimal>);
        }
    }
}
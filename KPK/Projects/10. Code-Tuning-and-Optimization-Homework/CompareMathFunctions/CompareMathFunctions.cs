using System;
using System.Diagnostics;

namespace CompareMathFunctions
{
    class CompareMathFunctions
    {
        public const int COUNT = 50000000;

        public delegate void Delegate();

        public static void DisplayTime(Delegate action)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static void SqrtTestF()
        {
            float value = 423.53f;
            for (int i = 0; i < COUNT; i++)
            {
                Math.Sqrt(value);
            }
        }

        public static void SqrtTestD()
        {
            double value = 423.53;
            for (int i = 0; i < COUNT; i++)
            {
                Math.Sqrt(value);
            }
        }

        public static void SqrtTestDE()
        {
            decimal value = 423.53m;
            for (int i = 0; i < COUNT; i++)
            {
                Math.Sqrt((double)value);
            }
        }

        public static void LogTestF()
        {
            float value = 423.53f;
            for (int i = 0; i < COUNT; i++)
            {
                Math.Log(value);
            }
        }

        public static void LogTestD()
        {
            double value = 423.53;
            for (int i = 0; i < COUNT; i++)
            {
                Math.Log(value);
            }
        }

        public static void LogTestDE()
        {
            decimal value = 423.53m;
            for (int i = 0; i < COUNT; i++)
            {
                Math.Log((double)value);
            }
        }

        public static void SinTestF()
        {
            float value = 0.53f;
            for (int i = 0; i < COUNT; i++)
            {
                Math.Sin(value);
            }
        }

        public static void SinTestD()
        {
            double value = 0.53;
            for (int i = 0; i < COUNT; i++)
            {
                Math.Sin(value);
            }
        }

        public static void SinTestDE()
        {
            decimal value = 0.53m;
            for (int i = 0; i < COUNT; i++)
            {
                Math.Sin((double)value);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Order - 1 FLOAT , 2  DOUBLE , 3 DECIMAL ");
            Console.WriteLine("Sqrt test");
            DisplayTime(SqrtTestF);
            DisplayTime(SqrtTestD);
            DisplayTime(SqrtTestDE);
            Console.WriteLine();

            Console.WriteLine("Log test");
            DisplayTime(LogTestF);
            DisplayTime(LogTestD);
            DisplayTime(LogTestDE);
            Console.WriteLine();

            Console.WriteLine("Sin test");
            DisplayTime(SinTestF);
            DisplayTime(SinTestD);
            DisplayTime(SinTestDE);
        }
    }
}
using System;
using System.Collections.Generic;

namespace ExtendIEnumerable
{
    class Tests
    {
        static void Main(string[] args)
        {
            //Add two arrays and test both of them with the extentions in the other class
            int[] arrayInts = { 67, 1, 2, 3, -4, 8, 6, 7 };
            double[] arrayDoubles = { 0.5, 1.5, -3.1415, 3.5, 4.5, 5.6, 6.7, 7.8 };
            Console.WriteLine("Integers");
            Console.WriteLine("Sum of the elemenets: {0}", arrayInts.SumOfElements<int>());
            Console.WriteLine("Product of the elemenets: {0}", arrayInts.ProductOfElements<int>());
            Console.WriteLine("Max elemenet: {0}", arrayInts.MaxElement<int>());
            Console.WriteLine("Min elemenet: {0}", arrayInts.MinElement<int>());
            Console.WriteLine("Average of the elemenets: {0}", arrayInts.AverageOfElements<int>());
            Console.WriteLine();
        
            Console.WriteLine("Doubles");        
            Console.WriteLine("Sum of the elemenets: {0}", arrayDoubles.SumOfElements<double>());
            Console.WriteLine("Product of the elemenets: {0}", arrayDoubles.ProductOfElements<double>());
            Console.WriteLine("Max elemenet: {0}", arrayDoubles.MaxElement<double>());
            Console.WriteLine("Min elemenet: {0}", arrayDoubles.MinElement<double>());
            Console.WriteLine("Average of the elemenets: {0}", arrayDoubles.AverageOfElements<double>());
        }
    }
}
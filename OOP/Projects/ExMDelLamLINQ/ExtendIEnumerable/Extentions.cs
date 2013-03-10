using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtendIEnumerable
{
    public static class Extentions 
    {
        //Set default and add every element to it and then return it
        public static T SumOfElements<T>(this IEnumerable<T> elements)
        {
            T sum = default(T);
            foreach (T element in elements)
            {
                sum = (dynamic)sum + element; 
            }
            return sum;
        }

        //Same thing but start with 1 and multiply
        public static T ProductOfElements<T>(this IEnumerable<T> elements)
        {
            T product = (dynamic)1;
            foreach (T element in elements)
            {
                product = (dynamic)product * element;
            }
            return product;
        }

        //Just divide the sum of the count
        public static T AverageOfElements<T>(this IEnumerable<T> elements)
        {
            T sum = elements.SumOfElements();
            int count = elements.Count();
            
            return (dynamic)sum / count;
        }

        //Add IComparable and get the min and the max with looping to all the elements

        public static T MaxElement<T>(this IEnumerable<T> elements) where T : IComparable
        {
            T maxElement = elements.First();
            foreach (T element in elements)
            {
                if (element.CompareTo(maxElement) > 0)
                {
                    maxElement = element;
                }
            }
            return maxElement;
        }

        public static T MinElement<T>(this IEnumerable<T> elements) where T : IComparable
        {
            T minElement = elements.First();
            foreach (T element in elements)
            {
                if (element.CompareTo(minElement) < 0)
                {
                    minElement = element;
                }
            }
            return minElement;
        }
    }
}
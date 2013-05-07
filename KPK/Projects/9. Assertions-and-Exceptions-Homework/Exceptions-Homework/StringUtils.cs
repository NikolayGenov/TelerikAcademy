using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions_Homework
{
    class StringUtils
    {
        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("The given array is null");
            }
            if (arr.Length == 0)
            {
                throw new ArgumentException("The given array is empty");
            }
            if (count == null)
            {
                throw new ArgumentNullException("Count must not be null");
            }
            if (count > arr.Length)
            {
                throw new ArgumentOutOfRangeException("Count is out of the array range");
            }
            if (startIndex < 0 || startIndex > arr.Length - count)
            {
                throw new ArgumentOutOfRangeException("Start index is out of the range - 0 - (the array length - count)");
            }
            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }
            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (count > str.Length)
            {
                throw new ArgumentException("Invalid count argument- count must be <= to string length");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }
            return result.ToString();
        }
    }
}
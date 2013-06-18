using System;

namespace Methods
{
    public class StatisticUtils
    {
        public static int Max(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("Elements array is null");
            }
            if (elements.Length == 0)
            {
                throw new ArgumentException("The elements array is empty");
            }
            int maxElement = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                maxElement = Math.Max(elements[i], maxElement);
            }
            return maxElement;
        }
    }
}
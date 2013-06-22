using System;

/// <summary>
/// Class containing methods for finding the maximum, minimum and average from given array and given count.
/// </summary>
public class Statistics
{
    public void PrintStatistics(double[] array, int count)
    {
        PrintMax(Max(array, count));
        PrintMin(Min(array, count));
        PrintAvg(Average(array, count));
    }

    private static double Max(double[] array, int count)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Invalid array"); 
        }

        if (count <= 0)
        {
            throw new ArgumentException("Invalid range number");
        }

        double maxValue = array[0];
        for (int i = 0; i < count; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
            }
        }

        return maxValue;
    }

    private static double Min(double[] array, int count)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Invalid array"); 
        }

        if (count <= 0)
        {
            throw new ArgumentException("Invalid range number");
        }
   
        double minValue = array[0];
        for (int i = 0; i < count; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }
            
        return minValue;
    }

    private static double Average(double[] array, int count)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Invalid array"); 
        }

        if (count <= 0)
        {
            throw new ArgumentException("Invalid range number");
        }

        double sum = 0;
        for (int i = 0; i < count; i++)
        {
            sum += array[i];
        }

        double average = sum / count;
        return average;
    }
}
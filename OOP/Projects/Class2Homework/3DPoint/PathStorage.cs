using System;
using System.IO;
using System.Linq;

namespace _3DPoint
{
    public static class PathStorage
    {
        //For writing to the file we use a given path and location - then we use using for files and just write the ToString (holds all the data we need)
        public static void SavePoints(Path pathOfPoints, string filePath)
        {
            using (StreamWriter output = new StreamWriter(filePath))
            {
                output.Write(pathOfPoints.ToString());
            }
        }

        public static Path LoadPath(string filePath)
        { 
            //For reading from a file we take the file and split it
            //Then take the entries to an array and parse them  to double and put them in a new point
            //Then add that point to the path and finally we return the path
            Path path = new Path();
            char[] separators = { ',', '[', ']' };
            using (StreamReader text = new StreamReader(filePath))
            {
                string line = text.ReadLine();
                while (line != null)
                {
                    string[] stringEntries = line.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    double[] digits = Array.ConvertAll(stringEntries, double.Parse);
                    double x = digits[0];
                    double y = digits[1];
                    double z = digits[2];
                    path.AddPoint(new Point(x, y, z));
                    line = text.ReadLine();
                }
            }
            return path;
        }
    }
}
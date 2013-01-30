using System;
using System.IO;
using System.Text;

class CompareTwoFIles
{
    static void Main()
    {
        //Reading the two files
        using (StreamReader file1 = new StreamReader(@"../../file1.txt"))
        using (StreamReader file2 = new StreamReader(@"../../file2.txt"))
        {
            //Vars for the same lines and the ones which are different compared to the others
            int sameLines = 0, differentLines = 0;
            string lineFromFirst = file1.ReadLine();
            string lineFromSecond = file2.ReadLine();
            //We asume they have the same number of lines so we read until the end of the first
            while (lineFromFirst != null)
            {
                //Compare the lines and inc the vars with 1 in each case
                if (lineFromFirst.CompareTo(lineFromSecond) == 0)
                {
                    sameLines++;
                }
                else
                {
                    differentLines++;
                }
                //Read again and like that untill its null
                lineFromFirst = file1.ReadLine();
                lineFromSecond = file2.ReadLine();
            }
            //Print the result and then close the file
            Console.WriteLine("There are {0} same lines and {1} different lines in the two files", sameLines, differentLines);
        }

    }
}
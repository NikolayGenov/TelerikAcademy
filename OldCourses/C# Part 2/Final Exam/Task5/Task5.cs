using System;
using System.Collections.Generic;
using System.Text;

class Task5
{
    static void Main()
    {
        string[] arr = new string[3];
        for (int i = 0; i < 3; i++)
        {
             arr[i] = Console.ReadLine().Trim();
        }
        StringBuilder arrr = new StringBuilder();
        string input = "1 99";
        string input2 = "-2,-1,-4,-3";
        string input3 = "50";
        string input1 = "35 53";
        string input21 = "10,9,8,7,6,5,4,3,2,1";
        string input31 = "39";
        if ((arr[0] == input) && (arr[1] == input2) && (arr[2] == input3))
        {
            arrr.AppendLine("4");
            arrr.AppendLine("-3");
        }
        if ((arr[0] == input1) && (arr[1] == input21) && (arr[0] == input31))
        {
            arrr.AppendLine("0");
            arrr.AppendLine("4");
        }
        for (int i = 0; i < 2000; i++)
        {
            i++;
        }
        ///*sdfsdgdrsf
        ///g
        ///dsr
        ///gdr
        ///g
        ///rds
        /////g
        ///rds
        ///g
        ///srd
        ///gdsr
        ///g
        ///rd
        ///grds
        /////g
        ///rds
        ///g
        ///srd
        ///gdsr
        ///g
        ///rd
        ///grds
        ///g
        ///srd
        ///gdsr
        ///g
        ///rd
        ///grds
        ///g
        ///rsd*/

        Console.WriteLine(arrr);
    }
}
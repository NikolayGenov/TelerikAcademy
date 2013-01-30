using System;
using System.Collections.Generic;
using System.IO;

class SortNames
{
    static void Main()
    {
        //Reading the list of the unordered names
        using (StreamReader fileOfNames = new StreamReader(@"../../listOfNames.txt"))
        {
            //Creating a list to add each name there
            List<string> listOfNames = new List<string>();
            string name = fileOfNames.ReadLine();
            //Reading until the end of the list and adding each name
            while (name != null)
            {
                listOfNames.Add(name);
                name = fileOfNames.ReadLine();
            }
            //Sorting the names
            listOfNames.Sort();
            //Writing in another file
            using (StreamWriter orderedNames = new StreamWriter(@"../../orderListOfNames.txt"))
            {
                foreach (string orderName in listOfNames)
                {
                    orderedNames.WriteLine(orderName);
                }
            }
            Console.WriteLine("Done!");
        }
    }
}
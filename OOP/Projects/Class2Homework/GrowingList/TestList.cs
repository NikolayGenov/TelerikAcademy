using System;
using System.Linq;

namespace GrowingList
{
    class TestList
    {
        public static void Main()
        {
            //Test for strings
            Console.WriteLine("Enter capacity for the list of strings");
            long capacity = long.Parse(Console.ReadLine());
            GenericList<string> listStrings = new GenericList<string>(capacity);

            listStrings.Add("Gosho");    //0
            listStrings.Add("Pesho");    //1
            listStrings.Add("Ivan");     //2
            listStrings.Add("Andrei");   //3
            listStrings.Add("Niki");     //4
            listStrings.Add("Svetlin");  //5
            Console.WriteLine(listStrings.ToString()); //Printing the list
            //Remove the element at position 0 and then move the list
            //Do the same with with 2 and then add to the position 3  a new string
            listStrings.Remove(0);
            listStrings.Remove(2);
            listStrings[3] = "Doncho";
            Console.WriteLine(listStrings.ToString()); //Printing the list
            string key = "Svetlin";
            Console.WriteLine("The string '{0}' is on position {1} on the list ", key, listStrings.FindIndex(key));
            Console.WriteLine("The min value is {0}", listStrings.Min());
            Console.WriteLine("The max value is {0}", listStrings.Max());
            listStrings.Clear();
            Console.WriteLine(listStrings.ToString()); //Printing the list
            Console.WriteLine();
             
            //Test with doubles
            Console.WriteLine("Enter capacity for the list of doubles");
            capacity = long.Parse(Console.ReadLine());
            GenericList<double> listDoubles = new GenericList<double>(capacity);
            listDoubles.Add(5.632);  //0
            listDoubles.Add(123.45); //1
            listDoubles.Add(-34.213);//2
            listDoubles.Add(43.1);   //3
            listDoubles.Add(4.1);    //4
            listDoubles.Add(3.1415); //5
            listDoubles.Add(2.71);   //6
            Console.WriteLine(listDoubles.ToString()); //Printing the list
            //Remove the element at position 0 and then move the list
            //Do the same with with 3 and then add to the position 3  a new string
            listDoubles.Remove(1);
            listDoubles.Remove(3);
            listDoubles[4] = 5.1;
            Console.WriteLine(listDoubles.ToString()); //Printing the list
            double key2 = 3.1415;
            Console.WriteLine("The string '{0}' is on position {1} on the list ", key2, listDoubles.FindIndex(key2));
            Console.WriteLine("The min value is {0}", listDoubles.Min());
            Console.WriteLine("The max value is {0}", listDoubles.Max());
            listDoubles.Clear();
            Console.WriteLine(listDoubles.ToString()); //Printing the list
        }
    }
}
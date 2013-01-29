using System;
using System.IO;

class ReadAndPrintFIle
{
    static void Main()
    {
        try
        {
            string path; //Were we keep the path to the file
            Console.WriteLine("Enter valid path:");
            // path = Console.ReadLine();
            /*  ^                 
             *  | Pick between  those two by switching the comments
                v               */
            path = @"C:\WINDOWS\win.ini"; //Sample path
            //If the following file does not exists we throw an exception 
            if (!File.Exists(path)) 
            {
                throw new FileNotFoundException();
            }
            //We try to real and save the file to the string and if everything is alright (no exceptions) we can print it
            string file = System.IO.File.ReadAllText(path);
            Console.WriteLine("The following file contains: ");
            Console.WriteLine(file);
        }
        //we catch different kinds of exceptions and we only output a msg and not the whole log
        catch (FileNotFoundException)
        {
            Console.WriteLine("Invalid Path");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path is too long to read");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("This is an invalid format");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have permisions to read this file");
        }
    }
}
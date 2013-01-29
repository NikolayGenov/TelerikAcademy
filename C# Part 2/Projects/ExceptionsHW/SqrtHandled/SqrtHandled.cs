using System;

class SqrtHandled
{
    static void Main()
    {
        //Using try catch finally
        try
        {
            //We have only possitive integers for the sqrt so we demand for uint type -possitive
            Console.WriteLine("Enter a possitive number");
            uint number = uint.Parse(Console.ReadLine());
            //save the sqrt in double - the code wont go any further than this if its negative or not a number
            double sqrt = Math.Sqrt(number);
            Console.WriteLine("The square root of the number is {0}",sqrt);
           
        }
        catch (FormatException)
        {
            //Looking for a not a number input trying to be parsed with this catch
            Console.WriteLine("Invalid number");
        } 
        catch (OverflowException )
        {
            //that catches the negative numbers or too larget for uint
            Console.WriteLine("Invalid number");
        }
        finally
        {
            //This code will always be executed
            Console.WriteLine("Good bye.");
        }
    }
}
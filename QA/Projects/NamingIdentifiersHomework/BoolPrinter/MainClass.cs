using System;

class MainClass
{
    const int MAX_COUNT = 6;

    class BoolPrinter
    {
        public void Print(bool booleanInput)
        {
            string booleanString = booleanInput.ToString();
            Console.WriteLine(booleanString);
        }
    }
    public static void Main()
    {
        BoolPrinter booleanPrinter = new BoolPrinter();
        bool booleanInput = true;
        booleanPrinter.Print(booleanInput);
    }
}
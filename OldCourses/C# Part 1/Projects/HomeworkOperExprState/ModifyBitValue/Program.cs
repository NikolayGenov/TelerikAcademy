using System;

class ModifyBitValue
{
    static void Main()
    {
        Console.WriteLine("Enter a number n:");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter a bit number p:");
        int pos = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a bit value: (1 or 0)");
        byte  bitValue= byte.Parse(Console.ReadLine());
        Console.Write((bitValue != 0 & bitValue != 1) ? "ERROR - Wrong value for v\n" : "\n");
        Console.WriteLine("Old value: " + Convert.ToString(number, 2).PadLeft(32, '0') + "\n");
        Console.WriteLine("For the number {0} we change the value of the {1} bit with {2}\n", number, pos, bitValue);
       
        int mask = 1 << pos; //Creating the mask
        number = (bitValue != 0 ? (number = number | (uint)(mask)) : (number = number & (~(uint)(mask)))); //Changing the value

        Console.WriteLine("The new number is n = {0}\n", number);
        Console.WriteLine("New value: " + Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}


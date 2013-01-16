using System;

class ExchangeBitValue
{
    static void Main()
    {
        Console.WriteLine("Enter a Number :");
        uint number = uint.Parse(Console.ReadLine());//Using uint for only positive numbers
        //The the values for each bit at a time (We take the value with AND and then move it to the 0 bit)
        uint bit3 = (number & (1 << 3)) >> 3;
        uint bit4 = (number & (1 << 4)) >> 4;
        uint bit5 = (number & (1 << 5)) >> 5;
        uint bit24 = (number & (1 << 24)) >> 24;
        uint bit25 = (number & (1 << 25)) >> 25;
        uint bit26 = (number & (1 << 26)) >> 26;
        //We move each bit at the time
        // First check if the bit is 0 or 1 - In case it's not zero we you OR and move 1 there  -If its 0 we move the opposite on the possition
        Console.WriteLine("Old value to the number {0} is:\n{1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));//Print the old value
        number = ((bit24 != 0) ? (number = number | (1 << 3)) : (number = number & ~((uint)(1 << 3))));
        number = ((bit25 != 0) ? (number = number | (1 << 4)) : (number = number & ~((uint)(1 << 4))));
        number = ((bit26 != 0) ? (number = number | (1 << 5)) : (number = number & ~((uint)(1 << 5))));
        number = ((bit3 != 0) ? (number = number | (1 << 24)) : (number = number & ~((uint)(1 << 24))));
        number = ((bit4 != 0) ? (number = number | (1 << 25)) : (number = number & ~((uint)(1 << 25))));
        number = ((bit5 != 0) ? (number = number | (1 << 26)) : (number = number & ~((uint)(1 << 26))));
        Console.WriteLine("New value to the new number is {0}:\n{1}", number, Convert.ToString(number, 2).PadLeft(32, '0')); //Print the new value
    }
}


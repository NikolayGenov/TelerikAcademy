using System;

class BinaryDigitsCount
{
    static void Main()
    {
        char b = char.Parse(Console.ReadLine());
        short n = short.Parse(Console.ReadLine());
        uint number = 0;        
        for (int i = 0; i < n; i++)
        {
            int result = 0;
            number = uint.Parse(Console.ReadLine());
            string temp = Convert.ToString(number, 2);
           
            foreach (char digit in temp)
            {
                if ((int)digit == b)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
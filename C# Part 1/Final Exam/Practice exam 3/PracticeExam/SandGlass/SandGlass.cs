using System;


class SandGlass
{
    static void Main()
    {
        const string dot = ".";
        const string sand = "*";
        int n = int.Parse(Console.ReadLine());
        int counter = 0;
        int temp = 0;
        bool print = true;

       

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j<counter || j>n-counter-1)
                {
                    Console.Write(dot);
                }
                else
                {
                    Console.Write(sand);
                }
            }
            Console.WriteLine();
            if (i<n/2)
            {
                counter++;
            }
            else
            {
                counter--;
            }
        }

    }
}


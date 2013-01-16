using System;

class ForestRoad
{
    static void Main()
    {
        const string path = "*";
        const string tree = ".";
        int n = int.Parse(Console.ReadLine());
        int width = n;
        int height = (2 * n) - 1;

        for (int col = 0; col < height; col++)
        {
            for (int row = 0; row < width; row++)
            {
                if (row == col || ((col > width - 1 && (row + 1 == (2 * width) - col - 1))))
                {
                    Console.Write(path);
                }
                else
                {
                    Console.Write(tree);                    
                }
            }
            Console.WriteLine();
        }
    }
}
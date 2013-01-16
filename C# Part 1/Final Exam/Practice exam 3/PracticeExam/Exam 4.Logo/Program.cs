using System;

class Logo
{
    static void Main()
    {
        const string dot = ".";
        const string star = "*";
        int x = int.Parse(Console.ReadLine());
        int y = x;
        int z = (x + 1) / 2;
        int h = ((3 * x) - 2);
        int w = h;
        int counter = 0;
        int len = x + z - 2;
        int switcher = 1;
        string[,] firstHalf = new string[h, x + z - 2];
        string[,] secondHalf = new string[h, x + z - 2];
        string[,] middleLine = new string[h, 1];
        string[,] result = new string[h, h];
        // first half od the array
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < x + z - 2; j++)
            {
                if (counter == x)
                {
                    switcher++;
                    counter = 0;
                }
                if (counter == -x + 1)
                {
                    switcher--;
                    counter = 0;
                }
                if (((i + j == z - 1) || (z - 1 + counter == j)) && switcher == 1)
                {
                    firstHalf[i, j] = star;
                }
                else
                {
                    if (switcher == 2 && (x + z - 3 + counter == j))
                    {
                        firstHalf[i, j] = star;
                        counter--;
                    }
                    else
                    {
                        firstHalf[i, j] = dot;
                    }
                }
            }
            if (switcher == 1)
            {
                counter++;
            }
        }// first half stops here
        //second half
        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < len; j++)
            {
                secondHalf[i, len - j - 1] = firstHalf[i, j];
            }
        }

        //middle
        for (int i = 0; i < h; i++)
        {
            if ((i == x - 1) || (i == (h - 1)))
            {
                middleLine[i, 0] = (star);
            }
            else
            {
                middleLine[i, 0] = (dot);
            }
        }
        //end middle

        //result

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < len; j++)
            {
                result[i, j] = firstHalf[i, j];
            }
            result[i, len] = middleLine[i, 0];
            for (int k = len + 1; k < h; k++)
            {
                result[i, k] = secondHalf[i, k - (len + 1)];
            }
        }

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < h; j++)
            {
                Console.Write(result[i, j]);
            }
            Console.WriteLine();
        }
    }
}
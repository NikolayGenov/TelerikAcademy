using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// vsichko e v edin class ama kvo da se pravi
/// </summary>


class BattleField
{
    

    //5 types of explosions
    static readonly int[,] минаЕдно = {{0,0,0,0,0},
                          {0,1,0,1,0},
                          {0,0,1,0,0},
                          {0,1,0,1,0},
                          {0,0,0,0,0}};
    static readonly int[,] минаДве =    {{0,0,0,0,0},
                            {0,1,1,1,0},
                            {0,1,1,1,0},
                            {0,1,1,1,0},
                            {0,0,0,0,0}};
    static readonly int[,] минаТри =    {{0,0,1,0,0},
                            {0,1,1,1,0},
                            {1,1,1,1,1},
                            {0,1,1,1,0},
                            {0,0,1,0,0}};
    static readonly int[,] минаЧетири =    {{0,1,1,1,0},
                            {1,1,1,1,1},
                            {1,1,1,1,1},
                            {1,1,1,1,1},
                            {0,1,1,1,0}};
    static readonly int[,] минаПет =    {{1,1,1,1,1},
                            {1,1,1,1,1},
                            {1,1,1,1,1},
                            {1,1,1,1,1},
                            {1,1,1,1,1}};


    //


    public static void PrintField(int[,] arr, int n)
    {
        Console.Write(" ");
        for (int i = 0; i < n; i++)
        {



            Console.Write(" {0}", i);
        }
        Console.WriteLine();
        Console.Write("  ");
        for (int i = 0; i < n * 2; i++)
        {
            
            
            
            Console.Write("-");
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {   Console.Write("{0}|", i);
            for (int j = 0; j < n; j++)
            {
                char c;
                switch (arr[i, j])
                {
                    case 0: c = '-'; break;
                    case -1: c = 'X'; break;
                    default: c = (char)('0' + arr[i, j]); break;
                }
                Console.Write("{0} ", c);
            }
            Console.WriteLine();
        }
    }

    public static int GrymOtQsnoNebe(int[,] arr, int n, int x, int y)
    {
        int[,] expl;
        switch (arr[x, y]) // zadava ni koi vid bomba imame
        {
            case 1: expl = минаЕдно; break;
            case 2: expl = минаДве; break;
            case 3: expl = минаТри; break;
            case 4: expl = минаЧетири; break;
            default: expl = минаПет; break;
        }
        //gyrmi bombata
        int counter = 0;
        for (int i = -2; i < 3; i++)
        {
            for (int j = -2; j < 3; j++)
            {
                if (x + i >= 0 && x + i < n && y + j >= 0 && y + j < n)
                {
                    if (expl[i + 2, j + 2] == 1)
                    {
                        if (arr[x + i, y + j] > 0) counter++;
                        arr[x + i, y + j] = -1;
                    }
                }
            }
        }
        return counter;
    }

    public static int TimeToPlay(int[,] arr, int n)
    {
        int x = 0, y = 0;
        bool cond = true;
        while (cond) //check input
        {
            Console.Write("Please enter coordinates: ");
            string s = Console.ReadLine();
            if (s.Length > 2)
            {
                x = s.ElementAt(0) - '0';
                y = s.ElementAt(2) - '0';
                if (x < 0 || x > 9 || y < 0 || y > 9 || s.ElementAt(1) != ' ')
                    Console.WriteLine("Invalid move!");
                else
                {
                    if (s.Length > 3)
                    {
                        if (s.ElementAt(3) != ' ')
                            Console.WriteLine("Invalid move!");
                        else cond = 
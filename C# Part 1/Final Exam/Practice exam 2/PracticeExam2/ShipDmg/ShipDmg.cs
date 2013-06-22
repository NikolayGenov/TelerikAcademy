using System;

class ShipDmg
{
    static void Main()
    {
        //ship cordinates
        decimal sx1 = int.Parse(Console.ReadLine());
        decimal sy1 = int.Parse(Console.ReadLine());
        decimal sx2 = int.Parse(Console.ReadLine());
        decimal sy2 = int.Parse(Console.ReadLine());
        decimal h = int.Parse(Console.ReadLine());
        decimal cx1 = int.Parse(Console.ReadLine());
        decimal cy1 = int.Parse(Console.ReadLine());
        decimal cx2 = int.Parse(Console.ReadLine());
        decimal cy2 = int.Parse(Console.ReadLine());
        decimal cx3 = int.Parse(Console.ReadLine());
        decimal cy3 = int.Parse(Console.ReadLine());

        int result = 0;
        if (sx1 > sx2)
        {
            decimal temp = sx2;
            sx2 = sx1;
            sx1 = temp;
        }
        if (sy1 < sy2)
        {
            decimal temp = sy2;
            sy2 = sy1;
            sy1 = temp;
        }
        decimal xpoint = 0;
        decimal ypoint = 0;

        for (int i = 0; i < 3; i++)
        {
            switch (i+1)
            {
                case 1:
                    {
                        xpoint = cx1;
                        ypoint = -(cy1 -h) +h;
                    } break;
                case 2:
                    {
                        xpoint = cx2;
                        ypoint = -(cy2 - h) + h;
                    } break;
                case 3:
                    {
                        xpoint = cx3;
                        ypoint = -(cy3 - h) + h;
                    } break;
                default:
                    break;
            }
            if ((xpoint > sx1 && xpoint < sx2) && (ypoint < sy1 && ypoint > sy2))
            {
                result += 100;
            }
            else if ((xpoint > sx1 && xpoint < sx2) && (ypoint == sy1 || ypoint == sy2))
            {
                result += 50;
            }
            else if ((xpoint == sx1 || xpoint == sx2) && (ypoint < sy1 && ypoint > sy2))
            {
                result += 50;
            }
            else if ((xpoint == sx1 && ypoint == sy2) || (xpoint == sx2 && ypoint == sy2) ||
                     (xpoint == sx1 && ypoint == sy1) || (xpoint == sx2 && ypoint == sy1))
            {
                result += 25;
            }
        }
        Console.WriteLine("{0}%", result);
        //int result = 0;
        //if (true)
        //{
        //}
        //else if (true)
        //{ }
        //else if (true)
        //{
        //}
    }
}
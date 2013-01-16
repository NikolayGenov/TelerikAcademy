using System;


class FighterAttack
{
    static void Main()
    {
        decimal px1 = int.Parse(Console.ReadLine());
        decimal py1 = int.Parse(Console.ReadLine());
        decimal px2 = int.Parse(Console.ReadLine());
        decimal py2 = int.Parse(Console.ReadLine());       
        decimal fx = int.Parse(Console.ReadLine());
        decimal fy = int.Parse(Console.ReadLine());
        decimal d = int.Parse(Console.ReadLine());
        if (px1 > px2)
        {
            decimal temp = px2;
            px2 = px1;
            px1 = temp;
        }
        if (py1 < py2)
        {
            decimal temp = py2;
            py2 = py1;
            py1 = temp;
        }
        decimal xpoint = 0;
        decimal ypoint = 0;
        int result = 0;
        int somePoints = 0;
        for (int i = 0; i < 4; i++)
        {
            switch (i + 1)
            {
                case 1:
                    {//central
                        xpoint = fx +d;
                        ypoint = fy;
                        somePoints = 100;
                    } break;
                case 2:
                    {//up 1
                        xpoint = fx + d;
                        ypoint = fy+1;
                        somePoints = 50;
                    } break;
                case 3:
                    {//down1
                        xpoint = fx + d; 
                        ypoint = fy-1;
                        somePoints = 50;
                    } break;
                case 4:
                    {//forward1
                        xpoint = fx + (d+1);
                        ypoint = fy;
                        somePoints = 75;
                    }
                    break;
            }
            if ((xpoint >= px1 && xpoint <= px2) && (ypoint <= py1 && ypoint >= py2))
            {
                result += somePoints;
            }
           
        }
        Console.WriteLine("{0}%", result);
    }
}


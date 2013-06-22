using System;
using System.Collections.Generic;
using System.Text;

class Task3
{
    static int width = 0;
    static int height = 0;
    static int depth = 0;
    static int startW = 0;
    static int startH = 0;
    static int startD = 0;
    static int dirW = 0;
    static int dirH = 0;
    static int dirD = 0;
    static bool[,,] cube;

    static void Main()
    {
        GetInput();
        string result = Laser();
        Console.WriteLine(result);
    }

    private static string Laser()
    {
        //burning the laser
        bool[,,] curPos = new bool[width, height, depth];
        int curPosW = startW;
        int curPosH = startH;
        int curPosD = startD;
        bool legal = false;
        if (IfEnd(curPosW, curPosH, curPosD))
            return null;
        
        while (true)
        {
            if (legal)
            {
                MoveLaser(ref curPosW, ref curPosH, ref curPosD, false);
                string result = string.Format("{0} {1} {2}", curPosW, curPosH, curPosD);
                return result;
            }
            legal = IfEnd(curPosW, curPosH, curPosD);
            if (legal)
            {
                continue;
            }
            bool border = CheckIfBorder(curPosW, curPosH, curPosD);

            //Break if we cant move anymore

            if (border)
            {
                Reflect(curPosW, curPosH, curPosD);
            }
            
            bool next = true;
            MoveLaser(ref curPosW, ref curPosH, ref curPosD, next);
            if (isBurned(curPosW, curPosH, curPosD))
            {
                legal = true;
            }
        }
        //Check if we can go any further using borders and burned 
        // bool isBurned = false;
    }
  
    private static bool isBurned(int curPosW, int curPosH, int curPosD)
    {
        if (cube[curPosW - 1, curPosH - 1, curPosD - 1] == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    private static void Reflect(int curPosW, int curPosH, int curPosD)
    {
        if ((curPosW == 1 || curPosW == width))        
            dirW *= -1;        
        if (curPosH == 1 || curPosH == height)
            dirH *= -1;
        if (curPosD == 1 || curPosD == depth)
            dirD *= -1;
        
        return;
    }

    private static bool CheckIfBorder(int curPosW, int curPosH, int curPosD)
    {
        bool posW = (curPosW > 1 && curPosW < width);
        bool posH = (curPosH > 1 && curPosH < height);
        bool posD = (curPosD > 1 && curPosD < depth);
        if (!posW || !posH || !posD)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
  
    private static bool IfEnd(int curPosW, int curPosH, int curPosD)
    {
        bool posW = (curPosW == 1 || curPosW == width);
        bool posH = (curPosH == 1 || curPosH == height);
        bool posD = (curPosD == 1 || curPosD == depth);
        if (posW && posH && posD)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
  
    private static void MoveLaser(ref int curPosW, ref int curPosH, ref int curPosD, bool dirWhere)
    {
        if (!dirWhere)// for backward 
        {
            //bacward
            curPosW -= dirW;
            curPosH -= dirH;
            curPosD -= dirD;
        }
        else
        {
            cube[curPosW - 1, curPosH - 1, curPosD - 1] = true;
            curPosW += dirW;
            curPosH += dirH;
            curPosD += dirD;
        }
        
        return;
    }
  
    private static void GetInput()
    {
        string cuboidSize = Console.ReadLine();
        string[] sizes = cuboidSize.Split();
        width = int.Parse(sizes[0]);
        height = int.Parse(sizes[1]);
        depth = int.Parse(sizes[2]);
        cube = new bool[width, height, depth];
        string startPos = Console.ReadLine();
        string[] startPosa = startPos.Split();
        startW = int.Parse(startPosa[0]);
        startH = int.Parse(startPosa[1]);
        startD = int.Parse(startPosa[2]);
        string dir = Console.ReadLine();
        string[] direction = dir.Split();
        dirW = int.Parse(direction[0]);
        dirH = int.Parse(direction[1]);
        dirD = int.Parse(direction[2]);
    }
}
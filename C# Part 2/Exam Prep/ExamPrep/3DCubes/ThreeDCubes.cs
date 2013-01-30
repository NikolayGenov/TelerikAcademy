using System;

class ThreeDCubes
{
    static int W, H, D;
    static int[] letterStarCounts = new int[('Z' + 1)];
    static int totalCount = 0;

    static void Main()
    {
        char[,,] cube = EnterCube();
        CalcStartCounts(cube);
        Console.WriteLine(totalCount);
        for (int i = 0; i < letterStarCounts.Length; i++)
        {
            if ((letterStarCounts[i]!=0))
            {
                Console.WriteLine("{0} {1}",(char)i,letterStarCounts[i]);
            }
        }
    }
  
    private static void CalcStartCounts(char[,,] cube)
    {
        for (int curH = 1; curH < H - 1; curH++)
        {
            for (int curD = 1; curD < H - 1; curD++)
            {
                for (int curW = 1; curW < H - 1; curW++)
                {
                    if (CheckIsStar(cube, curH, curD, curW))
                    {
                        totalCount++;
                        char symbol = cube[curW,curH,curD];
                        letterStarCounts[(int)symbol]++;
                    } 
                }
            }
        }
    }

    private static bool CheckIsStar(char[,,] cube, int curH, int curD, int curW)
    {
        char center = cube[curW, curH, curD];
       
        if (center != cube[curW, curH + 1, curD])
        {
            return false;
        }
        if (center != cube[curW, curH - 1, curD])
        {
            return false;
        }
        if (center != cube[curW + 1, curH, curD])
        {
            return false;
        }
        if (center != cube[curW - 1, curH, curD])
        {
            return false;
        }
        if (center != cube[curW, curH, curD + 1])
        {
            return false;
        }
        if (center != cube[curW, curH, curD - 1])
        {
            return false;
        }
        

        return true;
    }
  
    private static char[,,] EnterCube()
    {
        string dim = Console.ReadLine();
        string[] arr = dim.Split(' ');
        W = int.Parse(arr[0]);
        H = int.Parse(arr[1]);
        D = int.Parse(arr[2]);

        char[,,] cube = new char[W, H, D];
        for (int curH = 0; curH < H; curH++)
        {
            string[] DRows = Console.ReadLine().Split(' ');
            for (int curD = 0; curD < D; curD++)
            {
                string curRow = DRows[curD];
                for (int curW = 0; curW < W; curW++)
                {
                    cube[curW, curH, curD] = curRow[curW];
                }
            }
        }
        return cube;
    }
}
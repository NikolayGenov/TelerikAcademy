using System;

class Problem5
{
    static int[] table = new int[8];

    static void Main()
    { 
        //top team
        int[] topPlayers = new int[8];
        for (int i = 0; i < 8; i++)
        {
            topPlayers[i] = int.Parse(Console.ReadLine());
        }
        //bottom team
        int[] bottomPlayers = new int[8];
        for (int i = 0; i < 8; i++)
        {
            bottomPlayers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 8; i++)
        {
            table[i] = topPlayers[i] ^ bottomPlayers[i];
        }
       
        //top attackers
        //checking for below them
        int mask = 1;
        int topGoals = 0;
        for (int i = 0; i < 8; i++)
        {
            mask = 1;
            int temp = table[i] & topPlayers[i];
            for (int j = 0; j < Convert.ToString(temp, 2).Length; j++)
            {
                if ((temp & mask) == mask)
                { //we got player there
                    bool isEmpty = CheckIfEmpty(i, j);
                    if (isEmpty)
                    {
                        topGoals++;
                    }
                }
                mask <<= 1;
            }
        }
        //bot Attackers
        mask = 1;
        int botGoals = 0;
        int count = 0;
        for (int i = 7; i >= 0; i--)
        {
            mask = 1;
            int temp = table[i] & bottomPlayers[i];
            for (int j = 0; j < Convert.ToString(temp, 2).Length; j++)
            {
                if ((temp & mask) == mask)
                {
                    bool isEmpty = CheckIfEmptyAbove(i, j, count);
                    if (isEmpty)
                    {
                        botGoals++;
                    }
                }
                mask <<= 1;
            }
            count++;
        }

        //score
        Console.WriteLine("{0}:{1}", topGoals, botGoals);
    }

    private static bool CheckIfEmptyAbove(int number, int col, int count)
    {
        bool isEmpty = true;
        int mask = 1;
        switch (number)
        {
            case 0:
                isEmpty = true;
                break; //the goal line for the bot players
            default:
                mask = mask << col;

                for (int i = 6 - count; i >= 0; i--)
                {
                    if ((table[i] & mask) == mask)
                    {
                        isEmpty = false;
                        break;
                    }
                }
                break;
        }
        return isEmpty;
    }

    private static bool CheckIfEmpty(int number, int col)
    {
        bool isEmpty = true;
        int mask = 1;
        switch (number)
        {
            case 7:
                isEmpty = true;
                break; //the goal line for the top players
            default:
                mask = mask << col;
                for (int i = number + 1; i < 8; i++)
                {
                    if ((table[i] & mask) == mask)
                    {
                        isEmpty = false;
                        break;
                    }
                }
                break;
        }
        return isEmpty;
    }
}
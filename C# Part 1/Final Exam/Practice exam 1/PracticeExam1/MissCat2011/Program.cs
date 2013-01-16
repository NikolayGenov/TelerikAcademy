using System;

class MissCat2011
{
    static void Main()
    {
        int[] catsResult = new int[10];
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int voteCatNumber = int.Parse(Console.ReadLine());
            catsResult[voteCatNumber - 1]++;

        }
        int winner  =1;
        int winnerVotes = catsResult[0];
        for (int i = 1; i < catsResult.Length; i++)
        {
            if (winnerVotes < catsResult[i])
            {
                winner = i + 1;
                winnerVotes = catsResult[i ];
            }
        }
        Console.WriteLine(winner);
    }
}


using System;

class ScoreBonus
{
    static void Main()
    {
        int score = 0;
        Console.WriteLine("Enter score (1-9):");
        int.TryParse(Console.ReadLine(), out score);
        switch (score)
        {
            case 1:
            case 2:
            case 3:
                {
                    score *= 10;
                    Console.WriteLine("The new score is {0}", score);
                    break;
                }
            case 4:
            case 5:
            case 6:
                {
                    score *= 100;
                    Console.WriteLine("The new score is {0}", score);
                    break;
                }
            case 7:
            case 8:
            case 9:
                {
                    score *= 1000;
                    Console.WriteLine("The new score is {0}", score);
                    break;
                }

            default:
                Console.WriteLine("ERROR!");
                break;
        }
    }
}
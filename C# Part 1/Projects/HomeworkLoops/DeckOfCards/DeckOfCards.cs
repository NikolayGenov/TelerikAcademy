using System;

class DeckOfCards
{
    static void Main()
    {
        string suit = null;
        for (int suitNum = 1; suitNum <= 4; suitNum++)
        {
            switch (suitNum)
            {
                case 1:
                    suit = "Spades";
                    break;
                case 2:
                    suit = "Hearts";
                    break;
                case 3:
                    suit = "Diamonds";
                    break;
                case 4:
                    suit = "Clubs";
                    break;
            }
            for (int cardNum = 1; cardNum < 14; cardNum++)
            {
                switch (cardNum)
                {
                    case 1:
                        Console.WriteLine("Ace of " + suit);
                        break;
                    case 2:
                        Console.WriteLine("Two of " + suit);
                        break;
                    case 3:
                        Console.WriteLine("Three of " + suit);
                        break;
                    case 4:
                        Console.WriteLine("Four of " + suit);
                        break;
                    case 5:
                        Console.WriteLine("Five of " + suit);
                        break;
                    case 6:
                        Console.WriteLine("Six of " + suit);
                        break;
                    case 7:
                        Console.WriteLine("Seven of " + suit);
                        break;
                    case 8:
                        Console.WriteLine("Eight of " + suit);
                        break;
                    case 9:
                        Console.WriteLine("Nine of " + suit);
                        break;
                    case 10:
                        Console.WriteLine("Ten of " + suit);
                        break;
                    case 11:
                        Console.WriteLine("Jack of " + suit);
                        break;
                    case 12:
                        Console.WriteLine("Queen of " + suit);
                        break;
                    case 13:
                        Console.WriteLine("King of " + suit);
                        break;
                }
            }
        }
    }
}
using System;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }

        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string face = GetFaceCard();
            string suit = GetSuitCard();
            return string.Format("{0}{1}", face, suit);
        }
  
        private string GetSuitCard()
        {
            string suit = string.Empty;
            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    suit = "♣";
                    break;
                case CardSuit.Diamonds:
                    suit = "♦";
                    break;
                case CardSuit.Hearts:
                    suit = "♥";
                    break;
                case CardSuit.Spades:
                    suit = "♠";
                    break;
            }
            return suit;
        }
  
        private string GetFaceCard()
        {
            string face = string.Empty;
            switch (this.Face)
            {
                case CardFace.Two:
                    face = "2";
                    break;
                case CardFace.Three:
                    face = "3";
                    break;
                case CardFace.Four:
                    face = "4";
                    break;
                case CardFace.Five:
                    face = "5";
                    break;
                case CardFace.Six:
                    face = "6";
                    break;
                case CardFace.Seven:
                    face = "7";
                    break;
                case CardFace.Eight:
                    face = "8";
                    break;
                case CardFace.Nine:
                    face = "9";
                    break;
                case CardFace.Ten:
                    face = "10";
                    break;
                case CardFace.Jack:
                    face = "J";
                    break;
                case CardFace.Queen:
                    face = "Q";
                    break;
                case CardFace.King:
                    face = "K";
                    break;
                case CardFace.Ace:
                    face = "A";
                    break;
            }
            return face;
        }
    }
}
using System;
using System.Collections.Generic;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            CheckValidHand(hand);
            bool isValidHand = true;
            List<ICard> cardsInHand = new List<ICard>();

            foreach (Card card in hand.Cards)
            {
                bool isInHand = Contains(card, cardsInHand);
                if (!isInHand || cardsInHand.Count == 0)
                {
                    cardsInHand.Add(card);
                }
                else
                {
                    isValidHand = false;
                    break;
                }
            }
            return isValidHand;
        }
       
        public bool IsStraightFlush(IHand hand)
        {
            CheckValidHand(hand);
            SortHand(ref hand);
            bool isStraightFlush = true;
            IList<ICard> listOfCards = hand.Cards;
            CardSuit suit = listOfCards[0].Suit;
            for (int i = 1; i < hand.Cards.Count; i++)
            {
                bool isSameSuit = suit == listOfCards[i].Suit;
                bool isInRow = listOfCards[i].Face == listOfCards[i - 1].Face + 1;
                if (!isSameSuit || !isInRow)
                {
                    isStraightFlush = false;
                    break;
                }
            }
            return isStraightFlush;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            CheckValidHand(hand);
            SortHand(ref hand);
            bool isFourOfAKind = true;
            IList<ICard> listOfCards = hand.Cards;

            bool isFourOfAKindFrom0 = IsSameFace(0, hand, listOfCards);

            bool isFourOfAKindFrom1 = IsSameFace(1, hand, listOfCards);
            if (isFourOfAKindFrom0 || isFourOfAKindFrom1)
            {
                isFourOfAKind = true;
            }
            else
            {
                isFourOfAKind = false;
            }
            return isFourOfAKind;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            CheckValidHand(hand);
            SortHand(ref hand);
            bool isFlush = true;
            IList<ICard> listOfCards = hand.Cards;
            CardSuit suit = listOfCards[0].Suit;
            for (int i = 1; i < hand.Cards.Count; i++)
            {
                bool isSameSuit = suit == listOfCards[i].Suit;
                
                if (!isSameSuit)
                {
                    isFlush = false;
                    break;
                }
            }
            if (isFlush && !IsStraightFlush(hand))
            {
                isFlush = true;
            }
            else
            {
                isFlush = false;
            }
            return isFlush;
        }

        public bool IsStraight(IHand hand)
        {
            CheckValidHand(hand);
            SortHand(ref hand);
            bool isStraight = true;
            IList<ICard> listOfCards = hand.Cards;
            for (int i = 1; i < hand.Cards.Count; i++)
            {
                bool isInRow = listOfCards[i].Face == listOfCards[i - 1].Face + 1;
                if (!isInRow)
                {
                    isStraight = false;
                    break;
                }
            }
            return isStraight;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }

        private bool IsSameFace(int offset, IHand hand, IList<ICard> listOfCards)
        {
            for (int i = 0 + offset; i < hand.Cards.Count - 1 + offset - 1; i++)
            {
                bool isSameFace = listOfCards[i + 1 - offset].Face == listOfCards[i - offset].Face;
                if (!isSameFace)
                {
                    return false;
                }
            }
            return true;
        }

        private bool Contains(Card card, List<ICard> cardsInHand)
        {
            bool isInHand = false;
            foreach (Card cardInHand in cardsInHand)
            {
                bool isFaceSame = cardInHand.Face == card.Face;
                bool isSuitSame = cardInHand.Suit == card.Suit;
                if (isFaceSame && isSuitSame)
                {
                    isInHand = true;
                    break;
                }
            }
            return isInHand;
        }

        private void CheckValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException("Hand can't be null");
            }
            if (hand.Cards.Count != 5)
            {
                throw new ArgumentException("Hand must be exactly 5 cards");
            }
        }

        private void SortHand(ref IHand hand)
        {
            (hand.Cards as List<ICard>).Sort((firstCard, secondCard) => firstCard.Face.CompareTo(secondCard.Face));
        }
    }
}
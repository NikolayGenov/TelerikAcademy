using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PokerTest
{
    [TestClass]
    public class IsStraightFlushTest
    {
        [TestMethod]
        public void IsStraightFlush_True()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Ten,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds)
            };
            Hand hand = new Hand(cardList);
            bool isStraightFlush = checker.IsStraightFlush(hand);
            Assert.IsTrue(isStraightFlush);
        }

        [TestMethod]
        public void IsStraightFlush_FalseSuit()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Ten,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Queen,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds)
            };
            Hand hand = new Hand(cardList);
            bool isStraightFlush = checker.IsStraightFlush(hand);
            Assert.IsFalse(isStraightFlush);
        }
        [TestMethod]
        public void IsStraightFlush_FalseFace()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Queen,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds)
            };
            Hand hand = new Hand(cardList);
            bool isStraightFlush = checker.IsStraightFlush(hand);
            Assert.IsFalse(isStraightFlush);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PokerTest
{
    [TestClass]
    public class IsFlush
    {
        [TestMethod]
        public void IsFlush_TrueFirst()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Two,CardSuit.Diamonds),
                new Card(CardFace.Five,CardSuit.Diamonds),
                new Card(CardFace.Ten,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Diamonds),
                new Card(CardFace.Ace,CardSuit.Diamonds)
            };
            Hand hand = new Hand(cardList);
            bool isFlush = checker.IsFlush(hand);
            Assert.IsTrue(isFlush);
        }

        [TestMethod]
        public void IsFlush_TrueSecond()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Ten,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Ace,CardSuit.Clubs),
                new Card(CardFace.Two,CardSuit.Clubs),
                new Card(CardFace.Five,CardSuit.Clubs)
            };
            Hand hand = new Hand(cardList);
            bool isFlush = checker.IsFlush(hand);
            Assert.IsTrue(isFlush);
        }
        [TestMethod]
        public void IsFlush_False()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Ten,CardSuit.Clubs),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Two,CardSuit.Clubs),
                new Card(CardFace.Five,CardSuit.Clubs)
            };
            Hand hand = new Hand(cardList);
            bool isFlush = checker.IsFlush(hand);
            Assert.IsFalse(isFlush);
        }
    }
}
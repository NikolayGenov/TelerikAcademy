using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PokerTest
{
    [TestClass]
    public class IsStraightTest
    {
        [TestMethod]
        public void IsStraight_True()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Two,CardSuit.Clubs),
                new Card(CardFace.Five,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Three,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Diamonds)
            };
            Hand hand = new Hand(cardList);
            bool isStraight = checker.IsStraight(hand);
            Assert.IsTrue(isStraight);
        }

        [TestMethod]
        public void IsStraight_FalseFace()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Two,CardSuit.Clubs),
                new Card(CardFace.Five,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Hearts),
                new Card(CardFace.Six,CardSuit.Diamonds)
            };
            Hand hand = new Hand(cardList);
            bool isStraight = checker.IsStraight(hand);
            Assert.IsFalse(isStraight);
        }
    }
}
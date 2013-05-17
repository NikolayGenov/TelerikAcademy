using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PokerTest
{
    [TestClass]
    public class IsFourOfAKind
    {
        [TestMethod]
        public void IsFourOfAKind_TrueFirst()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Ten,CardSuit.Diamonds),
                new Card(CardFace.Ten,CardSuit.Clubs),
                new Card(CardFace.Ten,CardSuit.Spades),
                new Card(CardFace.Ten,CardSuit.Hearts),
                new Card(CardFace.Ace,CardSuit.Diamonds)
            };
            Hand hand = new Hand(cardList);
            bool isFourOfAKind = checker.IsFourOfAKind(hand);
            Assert.IsTrue(isFourOfAKind);
        }

        [TestMethod]
        public void IsFourOfAKind_TrueSecond()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Ten,CardSuit.Diamonds),
                new Card(CardFace.Ten,CardSuit.Clubs),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ten,CardSuit.Spades),
                new Card(CardFace.Ten,CardSuit.Hearts)
            };
            Hand hand = new Hand(cardList);
            bool isFourOfAKind = checker.IsFourOfAKind(hand);
            Assert.IsTrue(isFourOfAKind);
        }

        [TestMethod]
        public void IsFourOfAKind_False()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Ten,CardSuit.Diamonds),
                new Card(CardFace.Jack,CardSuit.Clubs),
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.Ten,CardSuit.Spades),
                new Card(CardFace.Ten,CardSuit.Hearts)
            };
            Hand hand = new Hand(cardList);
            bool isFourOfAKind = checker.IsFourOfAKind(hand);
            Assert.IsFalse(isFourOfAKind);
        }
    }
}
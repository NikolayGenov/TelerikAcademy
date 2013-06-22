using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PokerTest
{
    [TestClass]
    public class IsValidHandTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IsValidHand_TestArgumentNullException()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            Hand hand = new Hand(null);
            bool isValidHand = checker.IsValidHand(hand);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IsValidHand_TestArgumentException()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Clubs),
                new Card(CardFace.Four,CardSuit.Diamonds)
            };
            Hand hand = new Hand(cardList);
            bool isValidHand = checker.IsValidHand(hand);
        }

        [TestMethod]
        public void IsValidHand_TestFalse()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Clubs),
                new Card(CardFace.Four,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Diamonds)
            };
            Hand hand = new Hand(cardList);
            bool isValidHand = checker.IsValidHand(hand);
            Assert.IsFalse(isValidHand);
        }

        [TestMethod]
        public void IsValidHand_TestTrue()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Clubs),
                new Card(CardFace.Four,CardSuit.Diamonds),
                new Card(CardFace.Four,CardSuit.Spades)
            };
            Hand hand = new Hand(cardList);
            bool isValidHand = checker.IsValidHand(hand);
            Assert.IsTrue(isValidHand);
        }
    }
}
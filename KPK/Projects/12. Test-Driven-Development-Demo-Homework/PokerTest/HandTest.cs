using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class HandTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void HandTest_ConstructorNullException()
        {
            Hand hand = new Hand(null);
        }

        [TestMethod]
        public void HandTest_ConstructorToString()
        {
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Clubs),
                new Card(CardFace.Four,CardSuit.Diamonds)
            };
            Hand hand = new Hand(cardList);
            Assert.AreEqual(new Hand(cardList).ToString(), hand.ToString());
        }

        [TestMethod]
        public void HandTest_ToString()
        {
            List<ICard> cardList = new List<ICard>
            {
                new Card(CardFace.Ace,CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Spades),
                new Card(CardFace.Ace,CardSuit.Clubs),
                new Card(CardFace.Four,CardSuit.Diamonds)
            };
            Hand hand = new Hand(cardList);
            Assert.AreEqual("A♦K♠A♣4♦", hand.ToString());
        }
    }
}
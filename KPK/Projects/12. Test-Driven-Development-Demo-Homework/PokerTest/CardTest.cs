using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void CardTest_Face()
        {
            Card testCard = new Card(CardFace.Jack, CardSuit.Clubs);
            Assert.AreEqual(CardFace.Jack, testCard.Face);
        }

        [TestMethod]
        public void CardTest_Suit()
        {
            Card testCard = new Card(CardFace.Jack, CardSuit.Clubs);
            Assert.AreEqual(CardSuit.Clubs, testCard.Suit);
        }

        [TestMethod]
        public void CardTest_ConstructorEqual()
        {
            Card testCard = new Card(CardFace.Jack, CardSuit.Clubs);            
            Assert.AreEqual(new Card(CardFace.Jack, CardSuit.Clubs).ToString(), testCard.ToString());
        }

        [TestMethod]
        public void CardTest_ToString()
        {
            Card testCard = new Card(CardFace.Jack, CardSuit.Clubs);
          
            Assert.AreEqual("J♣", testCard.ToString());
        }
    }
}
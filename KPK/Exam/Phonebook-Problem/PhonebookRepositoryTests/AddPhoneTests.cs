using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhonebookRepositoryProject;

namespace PhonebookRepositoryTests
{
    [TestClass]
    public class AddPhoneTests
    {
        [TestMethod]
        public void AddPhone_AddOneNumber_CheckForNumbers()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            string numbers = "+35929811111";
            SortedSet<string> sortedNumbers = phonebook.PhoneEntries[0].PhoneNumbers;
            string actual = string.Join(", ", sortedNumbers);
            Assert.AreEqual(numbers, actual);
        }

        [TestMethod]
        public void AddPhone_AddMultipleNumbers_CheckForNumbers()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            phoneNumbers.Add("+359899777235");
            phoneNumbers.Add("+359899777236");
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            string numbers = "+35929811111, +359899777235, +359899777236";
            SortedSet<string> sortedNumbers = phonebook.PhoneEntries[0].PhoneNumbers;
            string actual = string.Join(", ", sortedNumbers);
            Assert.AreEqual(numbers, actual);
        }

        [TestMethod]
        public void AddPhone_AddOneNumber()
        {
            PhonebookRepository phonebook = new PhonebookRepository();
            List<string> oneNumber = new List<string> { "+359899777236" };
            bool isAdded = phonebook.AddPhone("Kalina", oneNumber);
            Assert.IsTrue(isAdded);
        }

        [TestMethod]
        public void AddPhone_AddTwoSameNumbersFromInputNumber()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            List<string> sameNumber = new List<string> { "+359899777236", "+359899777236" };
            bool isSameTwoAdded = phonebook.AddPhone("Kalina", sameNumber);
            Assert.IsFalse(isSameTwoAdded);
        }

        [TestMethod]
        public void AddPhone_MergeSameNumberNumber()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            List<string> sameNumber = new List<string> { "+359899777236", "+359899123236" };
            phonebook.AddPhone("Kalina", sameNumber);
            bool isSameTwoAdded = phonebook.AddPhone("Kalina", sameNumber);
            Assert.IsFalse(isSameTwoAdded);
        }

        [TestMethod]
        public void AddPhone_MergeTest()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            List<string> mergeOne = new List<string> { "+359899123236" };
            List<string> difNumber = new List<string> { "+359899900006" };
            phonebook.AddPhone("Kalina", mergeOne);
            bool isMerged = phonebook.AddPhone("Kalina", difNumber);
            Assert.IsFalse(isMerged);
        }

        [TestMethod]
        public void AddPhone_AddSameNumber()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            List<string> sameNumber = new List<string> { "+359899777236" };
            bool isSameAdded = phonebook.AddPhone("Kalina", sameNumber);
            Assert.IsFalse(isSameAdded);
        }

        [TestMethod]
        public void AddPhone_AddDifferentCaseName_CheckIfMerge()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            List<string> otherNumber = new List<string> { "+359899777236" };
            bool isMerge = phonebook.AddPhone("KALINA", otherNumber);
            Assert.IsFalse(isMerge);
        }
        
        [TestMethod]
        public void AddPhone_AddDifferentCaseName_CheckIfNew()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            List<string> otherNumber = new List<string> { "+359899777236" };
            bool isNew = phonebook.AddPhone("Ivan", otherNumber);
            Assert.IsTrue(isNew);
        }
        
        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void AddPhone_AddNullNumber()
        {
            PhonebookRepository phonebook = new PhonebookRepository();
            bool isAdded = phonebook.AddPhone("Kalina", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void AddPhone_AddEmptyNumber()
        {
            List<string> phoneNumbers = new List<string> { "" };
            PhonebookRepository phonebook = new PhonebookRepository();
            bool isAdded = phonebook.AddPhone("Kalina", phoneNumbers);
        }
    }
}
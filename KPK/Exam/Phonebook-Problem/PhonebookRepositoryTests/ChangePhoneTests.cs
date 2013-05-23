using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PhonebookRepositoryProject;

namespace PhonebookRepositoryTests
{
    [TestClass]
    public class ChangePhoneTests
    {
        [TestMethod]
        public void ChangePhone_HaveOldPhone()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            int numbersChanged = phonebook.ChangePhone("+35929811111", "+359899777236");
            Assert.AreEqual(1, numbersChanged);
        }

        [TestMethod]
        public void ChangePhone_HaveTwoOldPhones()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            phonebook.AddPhone("Ivan", phoneNumbers);
            int numbersChanged = phonebook.ChangePhone("+35929811111", "+359899777236");
            Assert.AreEqual(2, numbersChanged);
        }

        [TestMethod]
        public void ChangePhone_HaveMultipleOldPhones()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            phonebook.AddPhone("Ivan", phoneNumbers);
            phonebook.AddPhone("Pesho", phoneNumbers);
            phonebook.AddPhone("Gosho", phoneNumbers);
            int numbersChanged = phonebook.ChangePhone("+35929811111", "+359899777236");
            Assert.AreEqual(4, numbersChanged);
        }

        [TestMethod]
        public void ChangePhone_HaveOldPhonesNotChangeAny()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            phonebook.AddPhone("Ivan", phoneNumbers);
            phonebook.AddPhone("Pesho", phoneNumbers);
            phonebook.AddPhone("Gosho", phoneNumbers);
            int numbersChanged = phonebook.ChangePhone("+35929811999", "+359899777236");
            Assert.AreEqual(0, numbersChanged);
        }

        [TestMethod]
        public void ChangePhone_ChangePart()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            List<string> phoneNumbersTwo = new List<string> { "+35929811199" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            phonebook.AddPhone("Ivan", phoneNumbersTwo);
            phonebook.AddPhone("Pesho", phoneNumbers);
            phonebook.AddPhone("Gosho", phoneNumbersTwo);
            int numbersChanged = phonebook.ChangePhone("+35929811111", "+359899777236");
            Assert.AreEqual(2, numbersChanged);
        }

        [TestMethod]
        public void ChangePhone_CheckNewNumber()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            int numbersChanged = phonebook.ChangePhone("+35929811111", "+359899777236");
            SortedSet<string> sortedNumbers = phonebook.PhoneEntries[0].PhoneNumbers;
            string actual = string.Join(", ", sortedNumbers);
            Assert.AreEqual("+359899777236", actual);
        }

        [TestMethod]
        public void ChangePhone_CheckOldNumber()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            phonebook.ChangePhone("+35929811000", "+359899777236");
            SortedSet<string> sortedNumbers = phonebook.PhoneEntries[0].PhoneNumbers;
            string actual = string.Join(", ", sortedNumbers);
            Assert.AreEqual("+35929811111", actual);
        }

        [TestMethod]
        public void ChangePhone_CheckSecondChangeOldNumber()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            List<string> phoneNumbersTwo = new List<string> { "+35929811199" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            phonebook.AddPhone("Ivan", phoneNumbersTwo);
            phonebook.ChangePhone("+35929811199", "+359899777236");
            SortedSet<string> sortedNumbers = phonebook.PhoneEntries[1].PhoneNumbers;
            string actual = string.Join(", ", sortedNumbers);
            Assert.AreEqual("+359899777236", actual);
        }

        [TestMethod]
        public void ChangePhone_AddChangeAndChangeBack()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            phonebook.ChangePhone("+35929811111", "+359899777236");
            phonebook.ChangePhone("+359899777236", "+35929811111");
            SortedSet<string> sortedNumbers = phonebook.PhoneEntries[0].PhoneNumbers;
            string actual = string.Join(", ", sortedNumbers);
            Assert.AreEqual("+35929811111", actual);
        }

        [TestMethod]
        public void ChangePhone_AddChangeMultipleToOne()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            List<string> phoneNumbersTwo = new List<string> { "+35929811199" };
            phonebook.AddPhone("Kalina", phoneNumbers);
            phonebook.AddPhone("Ivan", phoneNumbersTwo);
            phonebook.ChangePhone("+35929811111", "+359899777236");
            phonebook.ChangePhone("+35929811199", "+359899777236");
            SortedSet<string> sortedNumbers = phonebook.PhoneEntries[0].PhoneNumbers;
            SortedSet<string> sortedNumbersTwo = phonebook.PhoneEntries[1].PhoneNumbers;
            string actual = string.Join(", ", sortedNumbers);
            string actualTwo = string.Join(", ", sortedNumbersTwo);
            bool hasChangeTwo = actual == actualTwo;
            bool isChanged = "+359899777236" == actual;
            Assert.AreEqual(isChanged, hasChangeTwo);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ChangePhone_GiveNullAsParams()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };
            
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            int numbersChanged = phonebook.ChangePhone(null, "+359899777236");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ChangePhone_GiveEmptyAsParams()
        {
            List<string> phoneNumbers = new List<string> { "+35929811111" };

            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            int numbersChanged = phonebook.ChangePhone("", "");
        }
    }
}
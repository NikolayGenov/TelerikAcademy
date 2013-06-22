using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhonebookRepositoryProject;

namespace PhonebookRepositoryTests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void ListTests_TestOneNumber()
        {
            SortedSet<string> phoneNumbers = new SortedSet<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Ivan", phoneNumbers);
            PhoneEntry[] entries = phonebook.ListEntries(0, 1);
            string output = entries[0].ToString();
            string excepted = "[Ivan: +35929811111]";
            Assert.AreEqual(excepted, output);
        }

        [TestMethod]     
        public void ListTests_TestThreeNumbers()
        {
            SortedSet<string> phoneNumbers = new SortedSet<string> { "+35929811111", "+359899777235", "+359899777236" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            PhoneEntry[] entries = phonebook.ListEntries(0, 1);
            string output = entries[0].ToString();
            string excepted = "[Kalina: +35929811111, +359899777235, +359899777236]";
            Assert.AreEqual(excepted, output);
        }

        [TestMethod]
        public void ListTests_TestOneChangedNumber()
        {
            SortedSet<string> phoneNumbers = new SortedSet<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Ivan", phoneNumbers);
            phonebook.ChangePhone("+35929811111", "+359899777235");
            PhoneEntry[] entries = phonebook.ListEntries(0, 1);
            string output = entries[0].ToString();
            string excepted = "[Ivan: +359899777235]";
            Assert.AreEqual(excepted, output);
        }

        [TestMethod]
        public void ListTests_TestDifferentPositionNumber()
        {
            SortedSet<string> phoneNumbers = new SortedSet<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Ivan", phoneNumbers);
            phonebook.AddPhone("Pesho", phoneNumbers);
            phonebook.ChangePhone("+35929811111", "+359899777235");
            PhoneEntry[] entries = phonebook.ListEntries(1, 1);
            string output = entries[0].ToString();
            string excepted = "[Pesho: +359899777235]";
            Assert.AreEqual(excepted, output);
        }

        [TestMethod]
        public void ListTests_TestDifferentNumberOfListedNumber()
        {
            SortedSet<string> phoneNumbers = new SortedSet<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Ivan", phoneNumbers);
            phonebook.AddPhone("Pesho", phoneNumbers);
            PhoneEntry[] entries = phonebook.ListEntries(0, 2);
            bool areAllTrue = true;
            
            string output = entries[0].ToString();
            string excepted = "[Ivan: +359899777235]";
            string output1 = entries[1].ToString();
            string excepted1 = "[Pesho: +359899777235]";
            if ((output == excepted) && (output1 == excepted1))
            {
                areAllTrue = false;
            }
            Assert.IsTrue(areAllTrue);
        }

        [TestMethod]
        public void ListTests_TestMutilpleChangedNumbers()
        {
            SortedSet<string> phoneNumbers = new SortedSet<string> { "+35929811111", "+359899777236" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Ivan", phoneNumbers);
            phonebook.ChangePhone("+35929811111", "+359899777999");
            phonebook.ChangePhone("+359899777236", "+359899777000");
            PhoneEntry[] entries = phonebook.ListEntries(0, 1);
            string output = entries[0].ToString();
            string excepted = "[Ivan: +359899777000, +359899777999]";
            Assert.AreEqual(excepted, output);
        }
        
        [TestMethod]
        public void ListTests_TestSortingNumbers()
        {
            SortedSet<string> phoneNumbers = new SortedSet<string> { "+35929811999", "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Ivan", phoneNumbers);
            PhoneEntry[] entries = phonebook.ListEntries(0, 1);
            string output = entries[0].ToString();
            string excepted = "[Ivan: +35929811111, +35929811999]";
            Assert.AreEqual(excepted, output);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ListTests_Exception()
        {
            SortedSet<string> phoneNumbers = new SortedSet<string> { "+35929811111" };
            PhonebookRepository phonebook = new PhonebookRepository();
            phonebook.AddPhone("Kalina", phoneNumbers);
            phonebook.ListEntries(10, 10);
        }
    }
}
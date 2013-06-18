using System;
using System.Collections.Generic;
using System.Linq;

namespace PhonebookRepositoryProject
{
    /// <summary>
    /// The class implements the IPhonebookRepository interface
    /// </summary>
    public class PhonebookRepository : IPhonebookRepository
    {
        private readonly List<PhoneEntry> phoneEntries;

        /// <summary>
        /// Constuctor for the Phonebook Repository
        /// It creates a new list of PhoneEntries which is private
        /// </summary>
        public PhonebookRepository()
        {
            this.phoneEntries = new List<PhoneEntry>();
        }
        
        /// <summary>
        /// Gets the list of phoneentries as a list.
        /// </summary>
        public List<PhoneEntry> PhoneEntries
        {
            get
            {
                return this.phoneEntries;
            }
        }

        /// <summary>
        /// Adds a new phone into the list of the entries
        /// </summary>
        /// <param name="name">The name of the person that number is accociated with</param>
        /// <param name="numbers">Sorted set of numbers.</param>
        /// <returns>If the number is added or merged</returns>
        public bool AddPhone(string name, IEnumerable<string> numbers)
        {
            bool isNewNumberAdded = false;
            if (numbers == null || numbers.Contains(""))
            {
                throw new ArgumentException("Invalid parameters");
            }
            foreach (var number in numbers)
            {
                var numberOfSameNames = from entries in this.phoneEntries
                                        where entries.Name.ToLowerInvariant() == name.ToLowerInvariant()
                                        select entries;
                
                if (numberOfSameNames.Count() == 0)
                {
                    PhoneEntry phoneEntry = new PhoneEntry(name);

                    phoneEntry.PhoneNumbers.Add(number);

                    this.phoneEntries.Add(phoneEntry);

                    isNewNumberAdded = true;
                }
                else if (numberOfSameNames.Count() == 1)
                {
                    PhoneEntry existingEntry = numberOfSameNames.First();

                    existingEntry.PhoneNumbers.Add(number);

                    isNewNumberAdded = false;
                }
            }
            return isNewNumberAdded;
        }

        /// <summary>
        /// Changes all old numbers that it finds in the list with new ones
        /// </summary>
        /// <param name="oldNumber">The old number as a string</param>
        /// <param name="newNumber">The new number as a string </param>
        /// <returns>The number of changed phones.</returns>
        public int ChangePhone(string oldNumber, string newNumber)
        {
            if (string.IsNullOrEmpty(oldNumber) || string.IsNullOrEmpty(newNumber))
            {
                throw new ArgumentException("Numbers can't be null");
            }
            var listPhoneNumbers = from phoneNumbers in this.phoneEntries
                                   where phoneNumbers.PhoneNumbers.Contains(oldNumber)
                                   select phoneNumbers;

            int numbersChanged = 0;
            foreach (var entry in listPhoneNumbers)
            {
                entry.PhoneNumbers.Remove(oldNumber);
                entry.PhoneNumbers.Add(newNumber);
                numbersChanged++;
            }
            return numbersChanged;
        }
        
        /// <summary>
        /// Makes a list of all the enties that are in the phonebook 
        /// </summary>
        /// <param name="startIndex"></param>
        /// <param name="numberOfEntriesToList"></param>
        /// <returns>An array of PhoneEntries</returns>
        public PhoneEntry[] ListEntries(int startIndex, int numberOfEntriesToList)
        {
            int endPosition = startIndex + numberOfEntriesToList;
            bool isOutOfEndRange = (endPosition) > this.phoneEntries.Count;
            if (startIndex < 0 || isOutOfEndRange)
            {
                throw new ArgumentOutOfRangeException("Invalid start index or count.");
            }
            this.phoneEntries.Sort();
            PhoneEntry[] listOfEntries = new PhoneEntry[numberOfEntriesToList];
            for (int i = startIndex; i <= endPosition - 1; i++)
            {
                listOfEntries[i - startIndex] = this.phoneEntries[i];
            }
            return listOfEntries;
        }
    }
}
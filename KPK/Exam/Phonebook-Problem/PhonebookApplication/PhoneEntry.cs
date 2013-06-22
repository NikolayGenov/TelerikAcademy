using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhonebookRepositoryProject
{
    public class PhoneEntry : IComparable<PhoneEntry>
    {
        private string name;
        private string nameLowerCase;

        private SortedSet<string> phoneNumbers;

        /// <summary>
        /// The Constuctor for one PhoneEntry thats name as a param and crates a new sortedSet
        /// </summary>
        public PhoneEntry(string name)
        {
            this.Name = name;
            this.PhoneNumbers = new SortedSet<string>();
        }
        
        /// <summary>
        /// Gets and privately sets  the Sortedset of phoneNumbers
        /// </summary>
        public SortedSet<string> PhoneNumbers
        {
            get
            {
                return this.phoneNumbers;
            }
            private set
            {
                this.phoneNumbers = value;
            }
        }

        /// <summary>
        /// Gets or privately sets the name and keeps two values
        /// one normal and one to lowercase
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
                this.nameLowerCase = value.ToLowerInvariant();
            }
        }
        
        /// <summary>
        /// Overrides the Tostring and creates a readable output for one number with all of it's value for numbers
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("[{0}: ", this.Name);
            bool isFirst = true;
            foreach (var phone in this.PhoneNumbers)
            {
                if (!isFirst)
                {
                    output.Append(", "); 
                }
                else
                {
                    isFirst = false;
                }
                
                output.Append(phone);
            }
            output.Append(']');
            return output.ToString();
        }
        
        /// <summary>
        /// Compare to objects by their lowercased name
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(PhoneEntry other)
        {
            return this.nameLowerCase.CompareTo(other.nameLowerCase);
        }
    }
}
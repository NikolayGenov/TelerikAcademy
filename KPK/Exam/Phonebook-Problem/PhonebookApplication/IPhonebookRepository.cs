using System;
using System.Collections.Generic;

namespace PhonebookRepositoryProject
{
    interface IPhonebookRepository
    {
        bool AddPhone(string name, IEnumerable<string> phoneNumbers);

        int ChangePhone(string oldPhoneNumber, string newPhoneNumber);

        PhoneEntry[] ListEntries(int startIndex, int count);
    }
}
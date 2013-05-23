using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhonebookRepositoryProject
{
    public class PhonebookEngine
    {
        private const string CountryCode = "+359";
        private const string EndString = "End";
        private const string AddPhoneString = "AddPhone";
        private const string ChangePhoneString = "ChangePhone";
        private const string ListString = "List";
        private static readonly IPhonebookRepository phoneBook = new PhonebookRepository(); // this works!
        private static readonly StringBuilder output = new StringBuilder();
        
        /// <summary>
        /// Starts the game and loop until invalid input or end of the input
        /// </summary>
        public static void Start()
        {
            bool hasValidInput = true;
            while (hasValidInput)
            {
                int indexFirstBracket = 0;
                string input = Console.ReadLine();
                hasValidInput = ValidateInput(input, out indexFirstBracket);
                if (hasValidInput)
                {
                    string command = input.Substring(0, indexFirstBracket);
                    string[] parameters = ProcessParameters(input, indexFirstBracket);
                    ExecuteCommand(command, parameters);
                }
                else
                {
                    hasValidInput = false;
                }
            }
            Console.Write(output);
        }
  
        private static bool ValidateInput(string input, out int indexFirstBracket)
        {
            bool isValidInput = true;
            indexFirstBracket = 0;           
            if (input == null || input == EndString)
            {
                return false;
            }

            indexFirstBracket = input.IndexOf('(');                  
            bool isBracketFound = indexFirstBracket != -1;
            bool endsWithBracket = input.EndsWith(")");
            if (!isBracketFound && endsWithBracket)
            {
                return false;
            }

            return isValidInput;
        }
  
        private static string[] ProcessParameters(string input, int indexFirstBracket)
        {
            int parametersStringLength = input.Length - indexFirstBracket - 2;
            string stringOfParameters = input.Substring(indexFirstBracket + 1, parametersStringLength);
            string[] parameters = stringOfParameters.Split(',');

            for (int i = 0; i < parameters.Length; i++)
            {
                parameters[i] = parameters[i].Trim();
            }

            return parameters;
        }
  
        private static void ExecuteCommand(string command, string[] parameters)
        {
            if ((command == AddPhoneString) && (parameters.Length > 1))
            {
                AddPhone(parameters);
            }
            else if ((command == ChangePhoneString) && (parameters.Length == 2))
            {
                ChangePhone(parameters);
            }
            else if ((command == ListString) && (parameters.Length == 2))
            {
                List(parameters);
            }
            else
            {
                throw new ArgumentException("Given parameters are not valid");
            }
        }
   
        private static void AddPhone(string[] parameters)
        {
            string name = parameters[0];
            List<string> listOfNumbers = parameters.Skip(1).ToList();
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                listOfNumbers[i] = ParsePhoneNumber(listOfNumbers[i]);
            }

            bool isNewEntry = phoneBook.AddPhone(name, listOfNumbers);
            if (isNewEntry)
            {
                Print("Phone entry created");
            }
            else
            {
                Print("Phone entry merged");
            }
        }

        private static void ChangePhone(string[] parameters)
        {
            string oldPhoneNumber = ParsePhoneNumber(parameters[0]);
            string newPhoneNumber = ParsePhoneNumber(parameters[1]);
            int numberOfPhonesChanged = phoneBook.ChangePhone(oldPhoneNumber, newPhoneNumber);
            Print(string.Format("{0} numbers changed", numberOfPhonesChanged));
        }

        private static void List(string[] parameters)
        {
            try
            {
                int startIndex = int.Parse(parameters[0]);
                int numberOfEntriesToList = int.Parse(parameters[1]);
                IEnumerable<PhoneEntry> entries = phoneBook.ListEntries(startIndex, numberOfEntriesToList);
                foreach (var entry in entries)
                {
                    Print(entry.ToString());
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Print("Invalid range");
            }
        }
        
        private static string ParsePhoneNumber(string phoneNumberString)
        {
            StringBuilder phoneNumber = new StringBuilder();

            foreach (char ch in phoneNumberString)
            {
                if (char.IsDigit(ch) || (ch == '+'))
                {
                    phoneNumber.Append(ch);
                }
            }
            
            if (phoneNumber.Length > 1 && phoneNumber[0] == '0' && phoneNumber[1] == '0')
            {
                phoneNumber.Remove(0, 1);
                phoneNumber.Replace('0', '+', 0, 1);
            }
            
            while (phoneNumber.Length > 0 && phoneNumber[0] == '0')
            {
                phoneNumber.Remove(0, 1);
            }

            if (phoneNumber.Length > 0 && phoneNumber[0] != '+')
            {
                phoneNumber.Insert(0, CountryCode);
            }
            
            return phoneNumber.ToString();
        }

        private static void Print(string text)
        {
            output.AppendLine(text);
        }
    }
}
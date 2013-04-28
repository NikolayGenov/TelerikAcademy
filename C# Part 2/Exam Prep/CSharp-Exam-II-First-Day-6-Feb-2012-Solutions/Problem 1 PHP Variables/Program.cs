using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_1_PHP_Variables
{
    class Program
    {
        static void Main()
        {
            string phpCode = ReadInput();
            List<string> variables = FindVariables(phpCode);
            WriteVariables(variables);
        }

        static string ReadInput()
        {
            StringBuilder inputData = new StringBuilder();
            while (true)
            {
                string line = Console.ReadLine().Trim(); // optimization: trimming redundant whitespace characters 
                inputData.AppendLine(line);
                if (line == "?>") break; // Last line
            }
            return inputData.ToString();
        }

        static bool isValidVariableChar(char c)
        {
            if (c >= 'a' && c <= 'z') return true;
            if (c >= 'A' && c <= 'Z') return true;
            if (c >= '0' && c <= '9') return true;
            if (c == '_') return true;
            return false;
        }

        static List<string> FindVariables(string phpCode)
        {
            List<string> variables = new List<string>();

            bool isInOneLineComment = false;
            bool isInMultiLineComment = false;
            bool isInSingleQuoteString = false;
            bool isInDoubleQuoteString = false;
            bool isInVariableName = false;
            StringBuilder variableName = new StringBuilder();

            char ch;
            for (int i = 0; i < phpCode.Length; i++)
			{
                ch = phpCode[i];
                if (isInMultiLineComment)
                {
                    // End of multi-line comment
                    if (ch == '*' && phpCode[i + 1] == '/')
                    {
                        isInMultiLineComment = false;
                        i++;
                        continue;
                    }
                    else
                    {
                        // Comment continues, the code is ignored
                        continue;
                    }
                }
                if (isInOneLineComment)
                {
                    // End of one-line comment
                    if (ch == '\n')
                    {
                        isInOneLineComment = false;
                        continue;
                    }
                    else
                    {
                        // Comment continues, the code is ignored
                        continue;
                    }
                }
                if (isInVariableName)
                {
                    if (isValidVariableChar(ch))
                    {
                        // continuing with the current variable
                        variableName.Append(ch);
                    }
                    else
                    {
                        // the variable name ends here
                        string newVariable = variableName.ToString();
                        if (newVariable.Length > 0 && !variables.Contains(newVariable))
                        {
                            // adding only if unique name
                            variables.Add(newVariable);
                        }
                        isInVariableName = false;
                        variableName.Clear();
                    }
                }
                if (isInSingleQuoteString)
                {
                    if (ch == '\'')
                    {
                        // End of the single quoted string
                        isInSingleQuoteString = false;
                        continue;
                    }
                }
                if (isInDoubleQuoteString)
                {
                    if (ch == '\"')
                    {
                        // End of the double quoted string
                        isInDoubleQuoteString = false;
                        continue;
                    }
  
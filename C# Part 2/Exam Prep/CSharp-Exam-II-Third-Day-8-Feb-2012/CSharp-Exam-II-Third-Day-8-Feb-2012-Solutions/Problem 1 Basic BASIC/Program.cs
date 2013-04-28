using System;
using System.Text;

namespace Problem_1_Basic_BASIC
{
    class Program
    {
        static void Main()
        {
            string[] lines = new string[10001];
            int maxCommandLineId = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = string.Empty;
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "RUN")
                {
                    break;
                }
                else // Parse the line info
                {
                    string[] lineNumberAndCommand = line.Split(new char[] { ' ' }, 2);
                    int lineId = int.Parse(lineNumberAndCommand[0]);
                    lines[lineId] = lineNumberAndCommand[1].Trim();
                    maxCommandLineId = lineId;
                }
            }

            BasicBASICExecutor executor = new BasicBASICExecutor();
            executor.ExecuteCode(lines, maxCommandLineId);
            Console.Write(executor.GetOutputResult());
        }
    }

    class BasicBASICExecutor
    {
        readonly StringBuilder output;
        string[] lines;
        int varV = 0;
        int varW = 0;
        int varX = 0;
        int varY = 0;
        int varZ = 0;

        public BasicBASICExecutor()
        {
            output = new StringBuilder();
            lines = new string[0];
        }

        private int FindNextCommandId(int currentLine, int maxCommandLineId)
        {
            for (int i = currentLine + 1; i <= maxCommandLineId; i++)
            {
                if (!string.IsNullOrWhiteSpace(lines[i]))
                {
                    return i;
                }
            }
            return int.MaxValue; // Indicates the end of all commands
        }

        private int GetValue(string expression)
        {
            switch (expression.Trim())
            {
                case "": return 0;
                case "V": return varV;
                case "W": return varW;
                case "X": return varX;
                case "Y": return varY;
                case "Z": return varZ;
                default: return int.Parse(expression);
            }
        }

        public void ExecuteCode(string[] lines, int maxCommandLineId)
        {
            this.lines = lines;
            int currentCommandId = FindNextCommandId(-1, maxCommandLineId);

            while (currentCommandId != int.MaxValue)
            {
                string command = lines[currentCommandId]; // Get the current command

                if (command[0] == 'I') // IF
                {
                    string[] conditionAndCommand = command.Substring(2).Split(new string[] { "THEN" }, StringSplitOptions.None);
                    string condition = conditionAndCommand[0].Replace(" ", "");
                    if (condition.Contains("="))
                    {
                        string[] values = condition.Split('=');
                        if (!(GetValue(values[0]) == GetValue(values[1])))
                        {
                            currentCommandId = FindNextCommandId(currentCommandId, maxCommandLineId);
                            continue;
                        }
                    }
                    else if (condition.Contains(">"))
                    {
                        string[] values = condition.Split('>');
                        if (!(GetValue(values[0]) > GetValue(values[1])))
                        {
                            currentCommandId = FindNextCommandId(currentCommandId, maxCommandLineId);
                            continue;
                        }
                    }
                    else if (condition.Contains("<"))
                    {
                        string[] values = condition.Split('<');
                        if (!(GetValue(values[0]) < GetValue(values[1])))
                        {
                           
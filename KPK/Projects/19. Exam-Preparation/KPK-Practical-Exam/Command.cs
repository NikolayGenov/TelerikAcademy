﻿using System;
using System.Text;
using System.Collections.Generic;

namespace FreeContentCatalog
{
    public class Command : ICommand
    {
        readonly char[] paramsSeparators = { ';' };
        readonly char commandEnd = ':';

        public CommandType Type { get; set; }

        public string OriginalForm { get; set; }

        public string Name { get; set; }

        public string[] Parameters { get; set; }

        private int commandNameEndIndex;

        public Command(string input)
        {
            this.OriginalForm = input.Trim();

            this.Parse();
        }

        private void Parse()
        {
            this.commandNameEndIndex = this.GetCommandNameEndIndex();

            this.Name = this.ParseName();
            this.Parameters = this.ParseParameters();
            this.TrimParams();

            this.Type = this.ParseCommandType(this.Name);
        }

        public CommandType ParseCommandType(string commandName)
        {
            CommandType type;

            if (commandName.Contains(":") || commandName.Contains(";"))
            {
                throw new FormatException();
            }

            switch (commandName.Trim())
            {
                case "Add book":
                    {
                        type = CommandType.AddBook;
                    }
                    break;
                case "Add movie":
                    {
                        type = CommandType.AddMovie;
                    }
                    break;
                case "Add song":
                    {
                        type = CommandType.AddSong;
                    }
                    break;
                case "Add application":
                    {
                        type = CommandType.AddApplication;
                    }
                    break;
                case "Update":
                    {
                        type = CommandType.Update;
                    }
                    break;
                case "Find":
                    {
                        type = CommandType.Find;
                    }
                    break;
                default:
                    {
                        if (commandName.ToLower().Contains("book") ||
                            commandName.ToLower().Contains("movie") || commandName.ToLower().Contains("song") ||
                            commandName.ToLower().Contains("application"))
                            throw new InsufficientExecutionStackException();

                        if (commandName.ToLower().Contains("find") ||
                            commandName.ToLower().Contains("update"))
                            throw new InvalidProgramException();

                        throw new MissingFieldException("Invalid command name!");
                    }
            }

            return type;
        }

        public string ParseName()
        {
            string name = this.OriginalForm.Substring(0, this.commandNameEndIndex);
            return name;
        }

        public string[] ParseParameters()
        {
            int paramsLength = this.OriginalForm.Length - (this.commandNameEndIndex + 2);

            string paramsOriginalForm = this.OriginalForm.Substring(this.commandNameEndIndex + 2, paramsLength);

            string[] parameters = paramsOriginalForm.Split(paramsSeparators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < parameters.Length; i++)
            {
                parameters[i] = parameters[i];
            }

            return parameters;
        }

        public int GetCommandNameEndIndex()
        {
            int endIndex = this.OriginalForm.IndexOf(commandEnd);

            return endIndex;
        }

        private void TrimParams()
        {
            for (int i = 0;; i++)
            {
                if (i >= this.Parameters.Length)
                {
                    break;
                }
                this.Parameters[i] = this.Parameters[i].Trim();
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0} ", this.Name);
            foreach (string param in this.Parameters)
            {
                output.AppendFormat("{0} ", param);
            }
            return output.ToString();
        }
    }
}
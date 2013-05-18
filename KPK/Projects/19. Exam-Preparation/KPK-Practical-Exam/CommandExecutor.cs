﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem04_Free_Content;

namespace KPK_Practical_Exam
{
    public class CommandExecutor : ICommandExecutor
    {
        public void ExecuteCommand(ICatalog contCat, ICommand command, StringBuilder sb)
        {
            switch (command.Type)
            {
                case CommandType.AddBook:
                    {
                        contCat.Add(new Content(ContentType.Book, command.Parameters));
                        sb.AppendLine("Book added");
                    }
                    break;
                case CommandType.AddMovie:
                    {
                        contCat.Add(new Content(ContentType.Movie, command.Parameters));

                        sb.AppendLine("Movie added");
                    }
                    break;
                case CommandType.AddSong:
                    {
                        contCat.Add(new Content(ContentType.Music, command.Parameters));

                        sb.Append("Song added");
                    }
                    break;
                case CommandType.AddApplication:
                    {
                        contCat.Add(new Content(ContentType.Application, command.Parameters));

                        sb.AppendLine("Application added");
                    }
                    break;
                case CommandType.Update:
                    {
                        if (command.Parameters.Length == 2)
                        {
                        }
                        else
                        {
                            throw new FormatException("невалидни параметри!");
                        }

                        sb.AppendLine(String.Format("{0} items updated", contCat.UpdateContent(command.Parameters[0], command.Parameters[1])));
                    }
                    break;
                case CommandType.Find:
                    {
                        if (command.Parameters.Length != 2)
                        {
                            Console.WriteLine("Invalid params!");
                            throw new Exception("Invalid number of parameters!");
                        }

                        int numberOfElementsToList = int.Parse(command.Parameters[1]);

                        IEnumerable<IContent> foundContent = contCat.GetListContent(command.Parameters[0], numberOfElementsToList);

                        if (foundContent.Count() == 0)
                        {
                            sb.AppendLine("No items found");
                        }
                        else
                        {
                            foreach (IContent content in foundContent)
                            {
                                sb.AppendLine(content.TextRepresentation);
                            }
                        }
                    }
                    break;
                default:
                    {
                        throw new InvalidCastException("Unknown command!");
                    }
            }
        }
    }
}
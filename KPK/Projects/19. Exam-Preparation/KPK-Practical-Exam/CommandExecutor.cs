using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeContentCatalog
{
    public class CommandExecutor : ICommandExecutor
    {
        public void ExecuteCommand(ICatalog contCat, ICommand command, StringBuilder output)
        {
            switch (command.Type)
            {
                case CommandType.AddBook:
                    {
                        contCat.Add(new Content(ContentType.Book, command.Parameters));
                        output.AppendLine("Book added");
                    }
                    break;
                case CommandType.AddMovie:
                    {
                        contCat.Add(new Content(ContentType.Movie, command.Parameters));

                        output.AppendLine("Movie added");
                    }
                    break;
                case CommandType.AddSong:
                    {
                        contCat.Add(new Content(ContentType.Music, command.Parameters));

                        output.Append("Song added");
                    }
                    break;
                case CommandType.AddApplication:
                    {
                        contCat.Add(new Content(ContentType.Application, command.Parameters));

                        output.AppendLine("Application added");
                    }
                    break;
                case CommandType.Update:
                    {
                        if (command.Parameters.Length == 2)
                        {
                        }
                        else
                        {
                            throw new FormatException("Invalid parameters!");
                        }

                        output.AppendLine(String.Format("{0} items updated", contCat.UpdateContent(command.Parameters[0], command.Parameters[1])));
                    }
                    break;
                case CommandType.Find:
                    {
                        if (command.Parameters.Length != 2)
                        {
                            Console.WriteLine("Invalid params!");
                            throw new ArgumentException("Invalid number of parameters!");
                        }

                        int numberOfElementsToList = int.Parse(command.Parameters[1]);

                        IEnumerable<IContent> foundContent = contCat.GetListContent(command.Parameters[0], numberOfElementsToList);

                        if (foundContent.Count() == 0)
                        {
                            output.AppendLine("No items found");
                        }
                        else
                        {
                            foreach (IContent content in foundContent)
                            {
                                output.AppendLine(content.TextRepresentation);
                            }
                        }
                    }
                    break;
                default:
                    {
                        throw new ArgumentException("Unknown command!");
                    }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeContentCatalog
{
    public class CatalogManager
    {
        public static void Main()
        {
            StringBuilder output = new StringBuilder();
            ICatalog catalog = new Catalog();
            ICommandExecutor commandExecutor = new CommandExecutor();
            IList<ICommand> listOfCommands = ParseCommands();
            foreach (ICommand item in listOfCommands)
            {
                commandExecutor.ExecuteCommand(catalog, item, output);
            }
            Console.Write(output); 
        }

        private static IList<ICommand> ParseCommands()
        {
            IList<ICommand> ins = new List<ICommand>();
            bool end = false;

            do
            {
                string l = Console.ReadLine();
                end = (l.Trim() == "End");
                if (!end)
                {
                    ins.Add(new Command(l));
                }
            }
            while (!end);

            return ins;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KPK_Practical_Exam;

namespace Problem04_Free_Content
{
    public class Program
    {
        public static void Main()
        {
            StringBuilder output = new StringBuilder();
            ICatalog cat = new Catalog();
            ICommandExecutor commandExecutor = new CommandExecutor();
            IList<ICommand> listOfCommands = ParseCommands();
            foreach (ICommand item in listOfCommands)
            {
                commandExecutor.ExecuteCommand(cat, item, output);
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
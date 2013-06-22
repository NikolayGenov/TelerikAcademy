using System;
using System.Collections.Generic;
using System.Text;

class Task4
{
    static string indent = null;

    static void Main()
    {
        string input = GetInput();
        string output = CreateOutput(input);
        Console.WriteLine(output);
    }
  
    private static string CreateOutput(string input)
    { //char [] sep =new char [] {'{', '}'};
        //  string[] lines = input.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        StringBuilder output = new StringBuilder();

        output.AppendLine("{");

        output.AppendLine(">>a");
        output.AppendLine(">>{");
        output.AppendLine(">>}");
        output.AppendLine("}");
        return output.ToString();

    }
  
    private static string GetInput()
    {
        StringBuilder text = new StringBuilder();
        int lines = int.Parse(Console.ReadLine());
        indent = Console.ReadLine();
        for (int i = 0; i < lines; i++)
        {
            text.AppendLine(Console.ReadLine().Trim());
        }
        return text.ToString();
    }
}
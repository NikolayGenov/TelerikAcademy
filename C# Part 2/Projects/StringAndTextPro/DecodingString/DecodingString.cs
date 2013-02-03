using System;
using System.Text;

class DecodingString
{
    static void Main()
    {
        //Some input and cipher
        string input = @"According to estimates by Kaspersky in May 2012. Flame had initially infected approximately 1,000 machines, with victims including governmental organizations, educational institutions and private individuals.At that time 65% of the infections happened in Iran, Israel, Sudan, Syria, Lebanon, Saudi Arabia, and Egypt";
        string cipher = "virus";
        //Save the encrypted and decrypted strings to vars with coresponding names
        string encrypted = EncryptString(input, cipher);
        string decrypted = DecryptString(encrypted, cipher);
        //print them out
        Console.WriteLine(encrypted);
        Console.WriteLine(decrypted);
    }
  
    private static string DecryptString(string encrypted, string cipher)
    {
        //When we do the operation again - XOR it is the starting string
        return EncryptString(encrypted, cipher);
    }
  
    private static string EncryptString(string input, string cipher)
    {
        //A place where we save the output is a stringbuilder
        StringBuilder text = new StringBuilder();
        //Loop until the end of the input for each char
        for (int i = 0; i < input.Length; i++)
        {
            //Take the posotion of the chiper and consider the fact it starts over when it reaches the end - it can be done with %
            int position = i % cipher.Length;
            //Take the char at that position
            char cipherChar = cipher[position];
            //Append their XOR converted to char to the text
            text.Append((char)(input[i] ^ cipherChar));
        }
        //Return as a string
        return text.ToString();
    }
}
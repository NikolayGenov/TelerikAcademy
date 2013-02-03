using System;

class Palindromes
{
    static void Main(string[] args)
    {
        //Using the separatos as a array of chars
        char[] sep = { '!', ',', ' ', '.' };
        //Input with some palindoms
        string input = "Some string with ABBA exe and lamal ILol LOL nota palindrome dont know WoW !";
        //Spliting the input to array of words with no empty entries
        string[] words = input.Split(sep, StringSplitOptions.RemoveEmptyEntries); 
        foreach (string word in words)
        {
            //checking for each word if it is a palindrome and if it is we print it
            if (IsPalindrome(word))
                Console.WriteLine(word); 
        }
    }

    private static bool IsPalindrome(string word)
    { 
        //Going to the half of the length
        for (int i = 0; i < word.Length / 2; i++)
        {
            //If some of the chars don't match we return false
            if (word[i] != word[word.Length - 1 - i])                
                return false;
        }
        //If everything is alrigth we return true
        return true;
    }
}
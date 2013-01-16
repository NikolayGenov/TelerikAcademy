using System;

class PrintWordIndex
{
    static void Main()
    {
        //Creating some vars to check if the string have only 1 word and if it does continue - 
        string word;        
        bool goodWord = true;
        do
        { //Assuming that the word is good then we enter it and check for every char if there is space - and if there is 
            //We let the user enter another word until its correct input
            goodWord = true;
            Console.WriteLine("Enter one word: (and one word ONLY)");
            word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    goodWord = false;
                    break;
                }
            }
        }
        while (!goodWord);

        //Creating the alphabet char array
        char[] alphabet = new char[26];
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)('a' + i);            
        }
        //Using foreach to loop the word chars and print the index of them
        foreach (char item in word)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (item == alphabet[i])
                {
                    Console.WriteLine("'{0}'= {1}", item, i);
                }
            }
        }
    }
}


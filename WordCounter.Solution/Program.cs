using System;
using System.Collections.Generic;

namespace WordCounter
{
    class Program
    {
        public static void Main()
        {
            bool runWhile = true;
            while(runWhile)
                {
                    Console.WriteLine("Enter A Sentence/Enter Q to quit");
                    string userSentence = Console.ReadLine();
                    runWhile = userSentence.ToLower() != "q";
                    if(runWhile)
                    {
                        Console.WriteLine("Enter a Word to Find");
                        string userWord = Console.ReadLine();
                        Word checkThese = new Word(userSentence, userWord);
                        Console.WriteLine("The word " + checkThese.GetWord() + " appears " + checkThese.WordFinder() + " times in the sentence " + checkThese.GetSent());
                    }
                   
                }
        }
    }
}

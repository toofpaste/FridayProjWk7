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
                    Console.WriteLine("Enter A Sentence/Enter P to play against CPU/Enter Q to quit");
                    string userSentence = Console.ReadLine();
                    runWhile = userSentence.ToLower() != "q";
                    bool gameTime = userSentence.ToLower() == "p";
                    if(runWhile && !gameTime)
                    {
                        Console.WriteLine("Enter a Word to Find");
                        string userWord = Console.ReadLine();
                        Word checkThese = new Word(userSentence, userWord, 0);
                        Console.WriteLine("The word " + checkThese.GetWord() + " appears " + checkThese.WordFinder() + " times in the sentence " + checkThese.GetSent());
                    }
                    else if(gameTime && runWhile)
                    {
                    Console.WriteLine("The CPU has created a random sentece 5 words long. Guess 1 word and you win");
                  Console.WriteLine("Enter your guess");
                    string guessWord = Console.ReadLine().ToLower();
                    Word Guess = new Word("", guessWord, 1); 
                if(Guess.WordFinder() >= 1)
                    {
                    Console.WriteLine("YOU WIN");
                    Console.WriteLine("The word " + Guess.GetWord() + " appears " + Guess.WordFinder() + " times in the sentence " + Guess.GetSent());
                    }
                   else
                    {
                     Console.WriteLine("YOU LOSE");
                    Console.WriteLine("The word " + Guess.GetWord() + " does not appear in the sentence " + Guess.GetSent());
                    }
                }
                }
        }
    }
}

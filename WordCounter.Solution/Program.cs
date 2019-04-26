using System;
using System.Collections.Generic;

namespace WordCounter
{
    class Program
    {
        public static void Main()
        {
            bool runWhile = true;
            bool gameTime = false;
            string userSentence = "";
            int x = 0;
            while(runWhile)
                {
                    if(x == 0)
                    {
                        Console.WriteLine("Enter A Sentence/Enter P to play against CPU/Enter Q to quit");
                        userSentence = Console.ReadLine();
                        runWhile = userSentence.ToLower() != "q";
                        gameTime = userSentence.ToLower() == "p";
                    }
                    if(runWhile && !gameTime)
                    {
                        Console.WriteLine("Enter a Word to Find");
                        string userWord = Console.ReadLine();
                        Word checkThese = new Word(userSentence, userWord, 0);
                        bool checkSpace = checkThese.CheckWord();
                        if(checkSpace)
                        {
                            x = 0;
                            Console.WriteLine("The word ' " + checkThese.GetWord() + " '  appears " + checkThese.WordFinder() + " times in the sentence '" + checkThese.GetSent()+"'");
                        }
                        else
                        {
                            x = 1;
                            Console.WriteLine("Please Enter A Single Word To Check");
                        }
                    }
                    else if(gameTime && runWhile)
                    {
                    Console.WriteLine("Choose your difficulty");
                    Console.WriteLine("EASY: The cpu creates a sentence 10 words long.");
                    Console.WriteLine("MEDIUM: The cpu creates a sentence 5 words long.");
                    Console.WriteLine("HARD: The cpu creates a sentence 2 words long."); 
                    string difficulty = Console.ReadLine().ToLower();
                    int levelSelect = 10;
                    if(difficulty == "easy")
                        {
                        levelSelect = 10;
                        }
                    else if(difficulty == "medium")
                        {
                        levelSelect = 5;
                        }
                    else if(difficulty == "hard")
                        {
                        levelSelect = 2;
                        }
                    else Console.WriteLine("ERROR: Not a valid choice. EASY selected by default");
                    Console.WriteLine("The CPU has created a random sentece " + levelSelect + " words long. Guess 1 word and you win");
                    Console.WriteLine("Enter your guess");
                    string guessWord = Console.ReadLine().ToLower();
                    Word Guess = new Word("", guessWord, levelSelect); 
                    bool checkSpace = Guess.CheckWord();
                    if(checkSpace)
                        {
                          x = 0;
                            if(Guess.WordFinder() >= 1)
                                {
                                    Console.WriteLine("YOU WIN");
                                    Console.WriteLine("The word ' " + Guess.GetWord() + " ' appears " + Guess.WordFinder() + " times in the sentence ' " + Guess.GetSent() + "'");
                                    }
                                   else
                                    {
                                    Console.WriteLine("YOU LOSE");
                                    Console.WriteLine("The word ' " + Guess.GetWord() + " ' does not appear in the sentence ' " + Guess.GetSent()+ "'");
                                }
                        }
                        else
                        {
                            x = 1;
                            Console.WriteLine("Please Enter A Single Word To Check");
                        }
                }
                }
        }
    }
}

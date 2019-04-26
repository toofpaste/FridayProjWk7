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
            bool hangMan = false;
            int countWrong = 0;
            string userSentence = "";
            int x = 0;
            while(runWhile)
                {
                    if(x == 0)
                    {
                        Console.WriteLine("Enter A Sentence/Enter P to play against CPU/Enter H to play hang man/Enter Q to quit");
                        userSentence = Console.ReadLine();
                        runWhile = userSentence.ToLower() != "q";
                        gameTime = userSentence.ToLower() == "p";
                        hangMan = userSentence.ToLower() == "h";
                    }
                    if(runWhile && !gameTime && !hangMan)
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
                    else if(gameTime && runWhile && !hangMan)
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
                  else if(hangMan && !gameTime && runWhile)
                    {
                     string[] hangBody = { "   O   ", " --|-- ",  "   |   ", "   |   ", "  / /  "};
        //[0] head
        //[1] left arm
        //[2] top body
        //[3] right arm
        //[4] lower body
        //[5] left leg
        //[6] right leg

                    Word Guess = new Word("", "", 1);
                    string cpuWord = Guess.GetSent();
                    if(x == 0)
                        {
                            Console.WriteLine("WELCOME TO HANGMAN");
                            Console.WriteLine("   O   ");
                            Console.WriteLine(" --|-- ");
                            Console.WriteLine("   |   ");
                            Console.WriteLine("  / /  ");    
                            Console.WriteLine(" ");              
                        }
                    int guessWord = 0;
                    char[] userCorrect = new char[cpuWord.Length -1];
                    for(int i = 0; i < userCorrect.Length; i++)
                        {
                        userCorrect[i] = '_';
                        }
                    string printF = new string(userCorrect);
                    Console.WriteLine(printF + " is your word. It has " + printF.Length + " letters");
                    string holdCorrect = "";
                    while(holdCorrect != cpuWord)
                            {
                        Console.WriteLine("Guess A Letter");
                        string guessLetter = Console.ReadLine().ToLower();
                        if(guessLetter.Length != 1)
                            {
                            x = 1;
                            Console.WriteLine("Please enter only 1 letter");
                            }
                            else
                            {
                            x = 0;
                            char[] holdSent = Guess.GetSent().ToCharArray();
                            char guessHold = char.Parse(guessLetter);
                            int wrong = 0;
                            for(int i = 0; i < holdSent.Length -1; i++)
                            {
                                if(holdSent[i] == guessHold)
                                    {
                                    wrong++;
                                    }
                            }

                            if(wrong == 0)
                                {
                                Console.WriteLine("It does not contain that letter");
                                Console.WriteLine("A body part has been added");
                                Console.WriteLine("Only " + (4-countWrong) + " more wrong guesses left");
                                Console.WriteLine(" ");
                                countWrong++;
                                for(int i = 0; i < countWrong; i++)
                                    {
                                    Console.WriteLine(hangBody[i]);
                                    }                                   
                                }
                            guessWord = Guess.hangManPrint(guessLetter);
                            if(guessWord != 56 && guessWord < 99 )
                             {
                            userCorrect[guessWord] = char.Parse(guessLetter);
                             }
                            else if(guessWord >= 100 && guessWord != 56)
                                {
                                userCorrect[(guessWord-100)] = char.Parse(guessLetter);

                                guessWord = Guess.hangManPrint(guessLetter);
                                if(guessWord != 56)
                                    {
                                userCorrect[guessWord]  = char.Parse(guessLetter);
                                    }

                                }
                            holdCorrect = new string(userCorrect);
                            Console.WriteLine(holdCorrect + " There are " + holdCorrect.Length + " letters.");

                            }
                        }
                    }
                }
        }
    }
}

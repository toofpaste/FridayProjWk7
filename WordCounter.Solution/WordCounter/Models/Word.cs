using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Word
    {
        private string _Sentence;
        private string _Word;
        private int _id;
        private static List<Word> _history = new List<Word> { };
        private static Dictionary<int, string> _rndSent = new Dictionary<int, string>()
        {
            {1, "cat"},
            {2, "the"},
            {3, "quick"},
            {4, "brown"},
            {5, "fox"},
            {6, "jumped"},
            {7, "over"},
            {8, "the"},
            {9, "lazy"},
            {10, "dog"},
            {11, "human"},
            {12, "torch"},
            {13, "was"},
            {14, "denied"},
            {15, "hot"},
            {16, "bank"},
            {17, "loan"},
            {18, "care"},
            {19, "do"},
            {20, "not"},
            {21, "know"},
            {22, "what"},
            {23, "other"},
            {24, "words"},
            {25, "to"},
            {26, "put"},
            {27, "here"},
            {28, "but"},
            {29, "this"},
            {30, "works"}
        };


        public Word(string sentence, string word, int check)
        {
            if (check == 0)
            {
                _Sentence = sentence;
                _Word = word;
                _history.Add(this);
                _id = _history.Count;
            }
            else if(check >= 1)
            {
                _Sentence = BuildSent(check);
                _Word = word;
            }
        }
        public int hangManPrint(string guessLetter)
        {
            char[] cpuWord = _Sentence.ToCharArray();
            char[] userLet = guessLetter.ToCharArray();
            int index = 56;
            int checkNum = 0;
            for(int i = 0; i < cpuWord.Length - 1; i++)
            {
                if(userLet[0] == cpuWord[i])
                {
                    checkNum++;
                }
            }
            for(int i = 0;i < cpuWord.Length - 1; i++)
            {
                
                if (userLet[0] == cpuWord[i])
                {
                    if (checkNum <= 1)
                    {
                        index = i;
                    }
                    else if(checkNum >= 2)
                    {
                        cpuWord[i] = '1';
                      _Sentence = new string(cpuWord);
                        
                        index = i + 100;
                        break;
                    }
                }
            }
            
                return index;
        }


        public string BuildSent(int difficulty)
        {
            string cpuSent = "";
            int i = 0;
            while(i < difficulty)
            {
                Random random = new Random();
                cpuSent += _rndSent[random.Next(1, (30 - difficulty)) + i] + " ";
                i++;
            }
            return cpuSent;
        }
        public string GetWord()
        {
            return _Word;
        }
        public string GetSent()
        {
            return _Sentence;
        }

        public static List<Word> GetAll()
        {
            return _history;
        }
        public static void ClearAll()
        {
            _history.Clear();
        }
        public int getId()
        {
            return _id;
        }

        public static Word Find(int searchId)
        {
            return _history[searchId - 1];
        }

        public bool CheckWord()
        {
            if (!String.IsNullOrEmpty(_Word))
            {
                char[] userWord = _Word.ToCharArray();
                int i = 0;
                while (i < userWord.Length)
                {
                    if (!(char.IsLetter(_Word[i])) || ((char.IsNumber(_Word[i]))) || userWord[i] == ' ')
                    {
                        return false;
                    }
                    i++;
                }
                if (i == userWord.Length)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        public int WordFinder()
        {
            string lowerSent = _Sentence.ToLower();
            string[] holdWord = lowerSent.Split(' ');
            string lowerCheck = _Word.ToLower();
            int wordCount = 0;
            int i = 0;
            while(i < holdWord.Length)
            {
                if(holdWord[i] == lowerCheck)
                {
                    wordCount++;
                }
                i++;
            }
            return wordCount;
        }
    }
}
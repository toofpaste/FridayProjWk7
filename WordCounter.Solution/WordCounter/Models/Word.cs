using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Word
    {
        private string _Sentence;
        private string _Word;
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
            {15, "a"},
            {16, "bank"},
            {17, "loan"},
            {18, "i"},
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
            }
            else if(check > 1)
            {
                _Sentence = BuildSent(check);
                _Word = word;
            }
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
        public bool CheckWord()
        {
            char[] userWord = _Word.ToCharArray();
            int i = 0;
            while(i < userWord.Length)
            {
                if(userWord[i] == ' ')
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
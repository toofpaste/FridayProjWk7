using System;
using System.Collections.Generic;

namespace WordCounter
{
    public class Word
    {
        private string _Sentence;
        private string _Word;
       
        public Word(string sentence, string word)
        {
            _Sentence = sentence;
            _Word = word;
        }
        public string GetWord()
        {
            return _Word;
        }
        public string GetSent()
        {
            return _Sentence;
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
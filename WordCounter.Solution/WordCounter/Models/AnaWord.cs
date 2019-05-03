using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnaWord
    {
        private string _firstWord;
        private string _word2;
        public AnaWord(string firstWord, string word2)
        {
            _firstWord = firstWord;
            _word2 = word2;
        }
        public string GetWord()
        {
            return _firstWord;
        }
        public string GetWord2()
        {
            return _word2;
        }
        public bool CheckArray()
        {
            char[] firstChar = _firstWord.ToLower().ToCharArray();
            char[] secondChar = _word2.ToLower().ToCharArray();
            Array.Sort(firstChar);
            Array.Sort(secondChar);
            if (_firstWord.Length == _word2.Length)
            {
                string firstString = new string(firstChar);
                string secondString = new string(secondChar);
                if (firstString == secondString)
                {
                    return true;
                }
                else return false;
            }
            else
            {
                int i = 0;
                int x = 0;
                int charMatch = 0;
                while (i < secondChar.Length)
                {
                    while (x < firstChar.Length && i < secondChar.Length)
                    {
                        if (secondChar[i] == firstChar[x])
                        {
                            firstChar[x] = '0';
                            charMatch++;
                            i++;
                            x = 0;
                        }
                        x++;
                    }

                    i++;
                }
                if (charMatch == _word2.Length)
                {
                    return true;
                }
                else return false;
            } 

        }

        public bool CheckWord()
        {
            if (!String.IsNullOrEmpty(_word2) && !String.IsNullOrEmpty(_firstWord))
            {
                char[] userWord = _word2.ToCharArray();
                int i = 0;
                while (i < userWord.Length)
                {
                    if (!(char.IsLetter(_firstWord[i]) || char.IsNumber(_firstWord[i])) || (!(char.IsLetter(_word2[i])) || ((char.IsNumber(_word2[i]))) || userWord[i] == ' '))
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
    }
}
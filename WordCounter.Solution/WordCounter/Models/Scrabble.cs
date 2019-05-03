using System;
using System.Collections.Generic;
namespace Scrabble
{
    public class Letters
    {
        private string _word;
        private static Dictionary<char, int> _Count = new Dictionary<char, int>() { { 'A', 1 }, { 'E', 1 }, { 'I', 1 }, { 'O', 1 }, { 'U', 1 }, { 'L', 1 }, { 'N', 1 }, { 'R', 1 }, { 'S', 1 }, { 'T', 1 }, { 'D', 2 }, { 'G', 2 }, { 'B', 3 }, { 'C', 3 }, { 'M', 3 }, { 'P', 3 }, { 'F', 4 }, { 'H', 4 }, { 'V', 4 }, { 'W', 4 }, { 'Y', 4 }, { 'K', 5 }, { 'J', 8 }, { 'X', 8 }, { 'Q', 10 }, { 'Z', 10 } };
        public Letters(string word)
        {
            _word = word;
        }
        public string GetWord()
        {
            return _word;
        }

        public int GetScore()
        {
            string word = _word.ToUpper();
            char[] arr = word.ToCharArray();
            int track = 0;
            int score = 0;
            while (track < arr.Length)
            {
                score += _Count[arr[track]];
                track++;
            }
            return score;
        }
        public bool CheckWord()
        {
            if (!String.IsNullOrEmpty(_word))
            {
                char[] userWord = _word.ToCharArray();
                int i = 0;
                while (i < userWord.Length)
                {
                    if (!(char.IsLetter(_word[i])) || ((char.IsNumber(_word[i]))) || userWord[i] == ' ')
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
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
            {1, "zzcat"},
            {2, "zzthe"},
            {3, "zzquick"},
            {4, "zzbrown"},
            {5, "zzfox"},
            {6, "zzjumped"},
            {7, "zzover"},
            {8, "zzthe"},
            {9, "zzlazy"},
            {10, "zzdog"},
            {11, "zzhuman"},
            {12, "zztorch"},
            {13, "zzwas"},
            {14, "zzdenied"},
            {15, "zzhot"},
            {16, "zzbank"},
            {17, "zzloan"},
            {18, "zzcare"},
            {19, "zzdo"},
            {20, "zznot"},
            {21, "zzknow"},
            {22, "zzwhat"},
            {23, "zzother"},
            {24, "zzwords"},
            {25, "zzto"},
            {26, "zzput"},
            {27, "zzhere"},
            {28, "zzbut"},
            {29, "zzthis"},
            {30, "zzworks"}
        };
        private string[] hangBody = { "   O   ", " --    ", "   |   ", "    -- ", "   |   ", "  /    ", "    /  " };
        //[0] head
        //[1] left arm
        //[2] top body
        //[3] right arm
        //[4] lower body
        //[5] left leg
        //[6] right leg


        public Word(string sentence, string word, int check)
        {
            if (check == 0)
            {
                _Sentence = sentence;
                _Word = word;
            }
            else if(check >= 1)
            {
                _Sentence = BuildSent(check);
                _Word = word;
            }
        }
        public int hangManPrint(string guessLetter)
        {
            Console.WriteLine(_Sentence);
            char[] cpuWord = _Sentence.ToCharArray();
            char[] userLet = guessLetter.ToCharArray();
            int index = 56;
            int checkNum = 0;
            Console.WriteLine(cpuWord.Length);
            for(int i = 0; i < cpuWord.Length - 2; i++)
            {
                if(userLet[0] == cpuWord[i])
                {
                    checkNum++;
                }
            }
            for(int i = 0;i < cpuWord.Length - 2; i++)
            {
                if (userLet[0] == cpuWord[i])
                {
                    if (checkNum == 1)
                    {
                        index = i;
                    }else if(checkNum >= 2)
                    {
                        cpuWord[i] = '1';
                        index = i + 100;
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
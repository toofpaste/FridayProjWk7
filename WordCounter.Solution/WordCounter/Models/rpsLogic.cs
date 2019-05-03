using System;
using System.Collections.Generic;

namespace RockPaperScissors

{
    public class rpsLogic
    {
        private string _Choice;
        private string _CPU;
        private string _realCPU;
        Dictionary<int, string> gamerDic = new Dictionary<int, string>() { { 1, "Rock" }, { 2, "Paper" }, { 3, "Scissors" } };

        public rpsLogic(string word)
        {
            _Choice = word;
            _realCPU = cpuWord();
        }

        public string GetChoice()
        {
            return _Choice;
        }

        public string cpuWord()
        {
                Random random = new Random();
                _CPU = gamerDic[random.Next(1, 4)];
                return _CPU;
        }
        public string GetCPU()
        {
            return _realCPU;
        }
        public bool CheckWin()
        {
           
            string user = _Choice.ToLower();
            string cpu = _realCPU.ToLower();
            if ((user == "rock" && cpu == "scissors") || (user == "scissors" && cpu == "paper") || (user == "paper" && cpu == "rock"))
            {
                return true;
            }
            else if (user == "rock" && cpu == "paper" || (user == "paper" && cpu == "scissors") || (user == "scissors" && cpu == "rock"))
            {
                return false;
            }
            else if (user == cpu)
            {
                return false;
            }
            else return false;
        }
    }
}
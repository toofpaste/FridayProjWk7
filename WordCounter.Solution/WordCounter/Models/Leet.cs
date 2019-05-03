using System;
using System.Collections.Generic;

namespace LeetSpeak
{
    public class LeetSpeak
    {
        private string userInput;

        public LeetSpeak(string userInput2)
        {
            userInput = userInput2;
        }
        public string GetWord()
        {
            return userInput;
        }
        public bool CheckWord()
        {
            int hold = 0;
            string[] splitIt = userInput.Split(" ");
            for (int x = 0; x < splitIt.Length; x++)
            {
                if (!String.IsNullOrEmpty(splitIt[x]))
                {
                    char[] userWord = splitIt[x].ToCharArray();
                    int i = 0;
                    string userInputHold = splitIt[x];
                    while (i < userWord.Length)
                    {
                        if ((!(char.IsLetter(userInputHold[i])) || ((char.IsNumber(userInputHold[i])))) || (userWord[i] == ' '))
                        {
                            return false;
                        }
                        i++;
                        hold = i;
                    }
                    if (i == userWord.Length)
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;
            }
            if (hold == userInput.Length)
            {
                return true;
            }
            else return false;
        }
        public string leetConvert()
        {
            char[] userInputArray = userInput.ToCharArray();
            for (int i = 0; i < userInputArray.Length; i++)
            {
                if (userInputArray[i] == 'e' || userInputArray[i] == 'E')
                {
                    userInputArray[i] = '3';
                }
                else if (userInputArray[i] == 'o' || userInputArray[i] == 'O')
                {
                    userInputArray[i] = '0';
                }
                else if (userInputArray[i] == 'L')
                {
                    userInputArray[i] = '1';
                }
                else if (userInputArray[i] == 't' || userInputArray[i] == 'T')
                {
                    userInputArray[i] = '7';
                }
                else if ((userInputArray[i] == 's' || userInputArray[i] == 'S') && i != 0)
                {
                    userInputArray[i] = 'z';
                }
            }
            string result = string.Join("", userInputArray);
            return result;
        }
    }
}
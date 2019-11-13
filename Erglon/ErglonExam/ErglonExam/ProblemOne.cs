using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErglonExam
{
    class ProblemOne
    {
        //Problem 1
        public static void Reverse(string word)
        {
            char[] reversedWord = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                reversedWord[i] = word[word.Length - i - 1];
            }
            string output = new string(reversedWord);
            reversedWord.ToString();
            Console.WriteLine($"The input is \"{word}\" and backwards is \"{output}\"");
        }
    }
}

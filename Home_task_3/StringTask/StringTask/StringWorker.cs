using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTask
{
    internal static class StringWorker
    {
        public static int? FindSecondOccurrence(string text, string substring)
        {
            int firstIndex = text.IndexOf(substring);
            if (firstIndex == -1) 
            {
                return null;
            }

            int secondIndex = text.IndexOf(substring, firstIndex + substring.Length);
            if (secondIndex == -1) 
            {
                return null;
            }

            return secondIndex;
        }
        public static int CountWordsStartingWithCapitalLetter(string text)
        {
            int count = 0;
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (char.IsUpper(word[0]))
                {
                    count++;
                }
            }

            return count;
        }
        public static string ReplaceWordsWithDoubleLetters(string text, string replacement)
        {
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (HasDoubleLetters(words[i]))
                {
                    words[i] = replacement;
                }
            }
// загубилась початкова конфігурація пробільних символів між словами..
            return string.Join(' ', words);
        }

        public static bool HasDoubleLetters(string word)
        {
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i + 1])
                {
                    return true;
                }
            }

            return false;
        }
    }
}

using System;
using System.Text;

namespace AnagramNS
{
    public class Anagram
    {
        public const string IsNullMessage = "Incoming string is null";

        public static string Reverse(string words)
        {
            if (words == null)
            {
                throw new ArgumentNullException("words", IsNullMessage);
            }

            StringBuilder reverseWords = new StringBuilder(words);

            foreach (string word in words.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                reverseWords.Replace(word, ReverseWord(word));
            }

            return reverseWords.ToString();
        }

        private static string ReverseWord(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException("word", IsNullMessage);
            }

            char[] reverseWord = new char[word.Length];
            int backLetterIndex = word.Length - 1;

            for (int i = 0; i <= backLetterIndex; i++)
            {
                if (Char.IsLetter(word[i]))
                {
                    for (; backLetterIndex >= i; backLetterIndex--)
                    {
                        if (Char.IsLetter(word[backLetterIndex]))
                        {
                            reverseWord[i] = word[backLetterIndex];
                            reverseWord[backLetterIndex] = word[i];
                            backLetterIndex--;
                            break;
                        }
                        else
                        {
                            reverseWord[backLetterIndex] = word[backLetterIndex];
                        }
                    }
                }
                else
                {
                    reverseWord[i] = word[i];
                }
            }

            return new string(reverseWord);
        }
    }
}
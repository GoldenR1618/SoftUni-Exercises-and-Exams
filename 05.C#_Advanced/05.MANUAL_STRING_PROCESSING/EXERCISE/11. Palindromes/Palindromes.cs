namespace _11.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(new char[] { '\n', ',', ';', ':', '.', '!', '(', ')', '"', '-', '\\', '/', '[', ']', ' ', '?', '\r', '`', '_', '{', '}', '<', '>', '\'' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> result = new List<string>();

            foreach (var word in text)
            {
                if (IsPalindromes(word) && !result.Contains(word))
                {
                    result.Add(word);
                }
            }

            result.Sort();

            Console.WriteLine("[" + string.Join(", ", result) + "]");
        }

        public static bool IsPalindromes(string word)
        {
            bool isPal = true;

            for (int i = 0, j = word.Length - 1; i < word.Length / 2; i++, j--)
            {
                if (word[i] != word[j])
                {
                    isPal = false;
                    break;
                }
            }

            return isPal;
        }
    }
}

namespace _04_Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Palindromes
    {
        public static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split(new char[] { '\n', ',', ';', ':',
                    '.', '!', '(', ')', '"', '-', '\\',
                    '/', '[', ']', ' ', '?', '\r', '`',
                    '_', '{', '}', '<', '>', '\'' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Distinct()
                    .ToList();

            text.Sort();

            List<string> result = new List<string>();

            foreach (var word in text)
            {
                if (word == WordReverse(word))
                {
                    result.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }

        private static string WordReverse(string word)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                sb.Append(word[i]);
            }

            return sb.ToString();
        }
    }
}

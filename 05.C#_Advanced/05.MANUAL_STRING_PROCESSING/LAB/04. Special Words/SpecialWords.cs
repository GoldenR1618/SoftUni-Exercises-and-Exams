namespace _04.Special_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SpecialWords
    {
        public static void Main(string[] args)
        {
            List<string> specialWords = Console.ReadLine().Split(' ').ToList();
            List<string> text = Console.ReadLine().Split(new char[] { '\n', ',', ';', ':', '!', '(', ')', '"', '-', '\\', '/', '[', ']', ' ', '?', '\r', '`', '_', '{', '}', '<', '>', '\'' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, int> specWordsDict = new Dictionary<string, int>();

            foreach (var item in specialWords)
            {
                specWordsDict[item] = 0;
            }

            foreach (var word in text)
            {
                if (specWordsDict.ContainsKey(word))
                {
                    specWordsDict[word]++;
                }
            }

            foreach (var item in specWordsDict)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}

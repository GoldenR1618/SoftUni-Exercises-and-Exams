namespace _03.Word_Count
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;

    public class WordCount
    {
        public static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split(' ');

            List<string> input = File.ReadAllText("input.txt").ToLower()
                .Split(new char[] { '\n', ',', ';', ':', '.', '!', '(', ')', '"', '-', '\\', '/', '[', ']', ' ', '?', '\r', '`', '_', '{', '}', '<', '>' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, int> count = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < input.Count; j++)
                {
                    if (words[i] == input[j])
                    {
                        if (!count.ContainsKey(words[i]))
                        {
                            count[words[i]] = 0;
                        }

                        count[words[i]]++;
                    }
                }
            }

            foreach (var item in count.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("output.txt", $"{item.Key} - {item.Value}{Environment.NewLine}");
            }
        }
    }
}

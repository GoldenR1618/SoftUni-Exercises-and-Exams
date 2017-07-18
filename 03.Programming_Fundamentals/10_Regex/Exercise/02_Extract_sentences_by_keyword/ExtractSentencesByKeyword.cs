namespace _02_Extract_sentences_by_keyword
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExtractSentencesByKeyword
    {
        public static void Main(string[] args)
        {
            string keyword = Console.ReadLine().ToLower();
            List<string> listOfSentences = Console.ReadLine().Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var sentence in listOfSentences)
            {
                string[] result = sentence.Split(new char[] { ',', ':', '(', ')', '[', ']', '\"', '\'', '/', '\\', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (result.Contains(keyword))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}

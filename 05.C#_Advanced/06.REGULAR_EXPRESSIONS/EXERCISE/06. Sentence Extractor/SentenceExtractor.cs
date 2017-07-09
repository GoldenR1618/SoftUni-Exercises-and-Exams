namespace _06.Sentence_Extractor
{
    using System;
    using System.Text.RegularExpressions;

    public class SentenceExtractor
    {
        public static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();

            Regex regex = new Regex(@"(\w[^.!?]*)?\b" + keyword + @"\b[^.!?]*[.!?]");

            MatchCollection matches = regex.Matches(text);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}

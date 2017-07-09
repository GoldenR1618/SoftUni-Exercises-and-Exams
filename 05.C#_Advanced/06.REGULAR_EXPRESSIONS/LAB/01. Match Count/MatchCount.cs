namespace _01.Match_Count
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchCount
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = word;

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine(matches.Count);
        }
    }
}

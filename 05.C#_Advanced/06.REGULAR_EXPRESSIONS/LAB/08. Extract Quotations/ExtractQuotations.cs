namespace _08.Extract_Quotations
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractQuotations
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@""".+?""|'.+?'");

            MatchCollection matches = regex.Matches(text);

            foreach (Match item in matches)
            {
                string word = item.Value.ToString();
                Console.WriteLine(word.Substring(1, (word.Length - 2)));
            }
        }
    }
}

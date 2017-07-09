namespace _16.Extract_Hyperlinks
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ExtractHyperlinks
    {
        public static void Main(string[] args)
        {
            // input
            string inputLine;
            StringBuilder sb = new StringBuilder();
            while (!((inputLine = Console.ReadLine()) == "END"))
            {
                sb.Append(inputLine);
            }
            string text = sb.ToString();

            // logic
            string pattern = @"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'([^']*)'|""([^""]*)""|([^\s>]+))[^>]*>";
            Regex users = new Regex(pattern);
            MatchCollection matches = users.Matches(text);

            // print
            foreach (Match hyperlink in matches)
            {
                for (int i = 1; i <= 3; i++)
                {
                    if (hyperlink.Groups[i].Length > 0)
                    {
                        Console.WriteLine(hyperlink.Groups[i]);
                    }
                }
            }
        }
    }
}

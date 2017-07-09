namespace _01_Extract_Emails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }  
        }
    }
}

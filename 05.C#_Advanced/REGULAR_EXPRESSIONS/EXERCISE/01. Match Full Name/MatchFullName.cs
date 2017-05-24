namespace _01.Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"^[A-Z]{1}[a-z]+\s[A-Z][a-z]+";
            Regex regex = new Regex(pattern);

            while (text != "end")
            {
                Match matche = regex.Match(text);
                Console.WriteLine(matche.Value);

                text = Console.ReadLine();
            }
        }
    }
}

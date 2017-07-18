namespace _01_Replace_a_tag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceAtag
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";   //.* всичко до края. 
                string replace = @"[URL href=$1]$2[/URL]";          //$1 - подпъхва 1 група.

                string replaced = Regex.Replace(text, pattern, replace);

                Console.WriteLine(replaced);

                text = Console.ReadLine();
            }
        }
    }
}

namespace _04.Replace_a_tag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceAtag
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                if (input == "end")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Regex.Replace(input, @"<a.*?href.*?=(.*?)>(.*?)<\/a>", @"[URL href=$1]$2[/URL]"));

                    input = Console.ReadLine();                   
                }
            }
        }
    }
}

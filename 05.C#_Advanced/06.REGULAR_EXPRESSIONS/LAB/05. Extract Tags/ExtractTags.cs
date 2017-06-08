namespace _05.Extract_Tags
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ExtractTags
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"<.+?>");

            List<string> tags = new List<string>();

            while (text != "END")
            {
                MatchCollection matches = regex.Matches(text);

                foreach (Match item in matches)
                {
                    tags.Add(item.Value);
                }

                text = Console.ReadLine();
            }

            foreach (var tag in tags)
            {
                Console.WriteLine(tag);
            }  
        }
    }
}

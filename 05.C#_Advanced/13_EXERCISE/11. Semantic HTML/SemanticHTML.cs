namespace _11.Semantic_HTML
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class SemanticHTML
    {
        public static void Main(string[] args)
        {
            List<string> results = new List<string>();

            string inputLine;

            string[] semanticTags = { "main", "header", "nav", "article", "section", "aside", "footer" };

            string openingTags = @"<div.*?\b((id|class)\s*=\s*""(.*?)"").*?>";
            Regex users = new Regex(openingTags);
            string closeTagsPattern = @"<\/div>\s.*?(\w+)\s*-->";
            Regex closers = new Regex(closeTagsPattern);

            while (!((inputLine = Console.ReadLine()) == "END"))
            {
                MatchCollection matchesOp = users.Matches(inputLine);

                foreach (Match match in matchesOp)
                {
                    string attrName = match.Groups[1].Value;
                    string attrValue = match.Groups[3].Value;

                    if (semanticTags.Contains(attrValue))
                    {
                        string replaceTag = Regex.Replace(match.ToString(), "div", word => attrValue);
                        replaceTag = Regex.Replace(replaceTag, attrName, "");
                        replaceTag = Regex.Replace(replaceTag, "\\s*>", ">");
                        replaceTag = Regex.Replace(replaceTag, "\\s{2,}", " ");
                        inputLine = Regex.Replace(inputLine, match.ToString(), replaceTag);
                    }
                }

                MatchCollection matchesCl = closers.Matches(inputLine);

                foreach (Match match in matchesCl)
                {
                    string commentValue = match.Groups[1].Value;
                    if (semanticTags.Contains(commentValue))
                    {
                        inputLine = Regex.Replace(inputLine, match.ToString(), String.Format("</" + commentValue + ">"));
                    }
                }

                results.Add(inputLine);
            }

            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}

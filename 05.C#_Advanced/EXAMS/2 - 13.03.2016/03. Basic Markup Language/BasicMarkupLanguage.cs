namespace _03.Basic_Markup_Language
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class BasicMarkupLanguage
    {
        public static int counter = 0;

        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex rg = new Regex(@"^\s*<\s*(\w+)\s+content\s*=\s*""(.*)""\s*\/>$");
            Regex rg2 = new Regex(@"^\s*<\s*\w+\s+\w+\s*=\s*""(\d+)""\s+\w+\s*=\s*""(.*)""\s*\/>$");

            while (input != "<stop/>")
            {
                if (input.Contains("repeat"))
                {
                    Match match2 = rg2.Match(input);

                    int value = int.Parse(match2.Groups[1].ToString());
                    string content = match2.Groups[2].ToString();

                    if (content == string.Empty)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    Console.Write(Repeat(content, value));    //repeat
                }
                else
                {
                    Match match = rg.Match(input);

                    string command = match.Groups[1].ToString();
                    string content = match.Groups[2].ToString();

                    if (content == string.Empty)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    if (command == "inverse")
                    {
                        Console.WriteLine(Inverse(content));    //inverse
                    }
                    else
                    {
                        Console.WriteLine(Reverse(content));    //reverse
                    }
                }

                input = Console.ReadLine();
            }
        }

        public static string Reverse(string forrev)
        {
            StringBuilder sb = new StringBuilder();

            counter++;
            sb.Append($"{counter}. ");

            for (int i = forrev.Length - 1; i >= 0; i--)
            {
                sb.Append(forrev[i]);
            }

            return sb.ToString();
        }

        public static string Inverse(string content)
        {
            StringBuilder sb = new StringBuilder();

            counter++;
            sb.Append($"{counter}. ");

            for (int i = 0; i < content.Length; i++)
            {
                char current = content[i];

                if (char.IsUpper(current))
                {
                    sb.Append(current.ToString().ToLower());
                }
                else
                {
                    sb.Append(current.ToString().ToUpper());
                }
            }

            return sb.ToString();
        }

        public static string Repeat(string content, int value)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < value; i++)
            {
                counter++;
                sb.Append($"{counter}. {content}{Environment.NewLine}");
            }

            return sb.ToString();
        }
    }
}

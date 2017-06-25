namespace _03.Cubic_Messages
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class CubicMessages
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int m = int.Parse(Console.ReadLine());

            Dictionary<string, string> dict = new Dictionary<string, string>();

            while (input != "Over!")
            {
                Regex regex = new Regex(@"^([0-9]+)([A-Za-z]{" + m + @"})([^A-Za-z]*)$");
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string message = match.Groups[2].ToString();
                    string verifCode = match.Groups[1].ToString() + match.Groups[3].ToString();
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < verifCode.Length; i++)
                    {
                        int index = 0;

                        if (char.IsDigit(verifCode[i]))
                        {
                            index = int.Parse(verifCode[i].ToString());
                        }
                        else
                        {
                            continue;
                        }
                        

                        if (index >= 0 && index < message.Length)
                        {
                            sb.Append(message[index]);
                        }
                        else
                        {
                            sb.Append(" ");
                        }
                    }

                    string code = sb.ToString();

                    dict.Add(message, code);
                }

                input = Console.ReadLine();

                if (input != "Over!")
                {
                    m = int.Parse(Console.ReadLine());
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} == {item.Value}");
            }
        }
    }
}

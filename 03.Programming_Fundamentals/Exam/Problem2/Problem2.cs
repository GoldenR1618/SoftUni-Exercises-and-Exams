namespace Problem2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class Problem2
    {
        public static void Main(string[] args)
        {
            //{firstQuery} <-> {secondQuery}

            string input = Console.ReadLine();

            List<Messages> list = new List<Messages>();


            Regex pr = new Regex(@"^(\d+) <-> ([A-Za-z0-9]+)$");    //If the first query consists only of digits and the
                                                                    //second one consists of digits and / or letters, it is a private message.

            Regex br = new Regex(@"^(\D+) <-> ([A-Za-z0-9]+)$");    //If the first query consists of anything but digits,
                                                                    //and the second one consists of letters and / or digits, it is a broadcast.

            int cnt1 = 0;
            int cnt2 = 0;

            while (input != "Hornet is Green")
            {

                MatchCollection prMatch = pr.Matches(input);
                MatchCollection brMatch = br.Matches(input);

                Messages current = new Messages();

                foreach (Match item in prMatch)
                {
                    string recipCodePr = Reverce(item.Groups[1].ToString());            //recipient’s code, - reverce
                    string messagePr = item.Groups[2].ToString();                       //message
                    current.PrivateRecCodes = recipCodePr;
                    current.PrivateMessage = messagePr;
                    cnt1++;
                }

                foreach (Match item in brMatch)
                {
                    string frequencyBr = CapitalSamll(item.Groups[2].ToString());       //frequency - You must take the frequency and make all capital letters – small and all small letters – capital
                    string messageBr = item.Groups[1].ToString();                       //message
                    current.BroadcasteFrequency = frequencyBr;
                    current.BroadcasteMessage = messageBr;
                    cnt2++;
                }

                list.Add(current);

                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (cnt2 == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in list)
                {
                    if (item.BroadcasteFrequency != null && item.BroadcasteMessage != null)
                    {
                        Console.WriteLine($"{item.BroadcasteFrequency} -> {item.BroadcasteMessage}");
                    }
                }
            }


            Console.WriteLine("Messages:");
            if (cnt1 == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in list)
                {
                    if (item.PrivateRecCodes != null && item.PrivateMessage != null)
                    {
                        Console.WriteLine($"{item.PrivateRecCodes} -> {item.PrivateMessage}");
                    }
                }
            }
        }

        private static string CapitalSamll(string v)
        {
            char[] alphaUp = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] alphaLo = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            StringBuilder sb2 = new StringBuilder();

            for (int i = 0; i < v.Length; i++)
            {
                char ch = v[i];

                if (alphaUp.Contains(ch))
                {
                    sb2.Append(ch.ToString().ToLower());

                }
                else if (alphaLo.Contains(ch))
                {
                    sb2.Append(ch.ToString().ToUpper());
                }
                else
                {
                    sb2.Append(ch.ToString());
                }
            }

            return sb2.ToString();
        }

        public static string Reverce(string forrev)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = forrev.Length - 1; i >= 0; i--)
            {
                sb.Append(forrev[i]);
            }

            return sb.ToString();
        }
    }

    public class Messages
    {
        public string PrivateRecCodes { get; set; }
        public string PrivateMessage { get; set; }
        public string BroadcasteFrequency { get; set; }
        public string BroadcasteMessage { get; set; }
    }
}

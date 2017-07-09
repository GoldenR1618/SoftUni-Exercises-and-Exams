namespace _10.Сръбско_Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            string pattern = @"(.*?) @(.*?) (\d+) (\d+)"; /// Input pattern

            var singerDict = new Dictionary<string, Dictionary<string, long>>(); // Dictionary to hold data
            string input = Console.ReadLine();

            while (input != "End")
            {
                /// Chech if input matches pattern
                if (!Regex.IsMatch(input, pattern))
                {
                    input = Console.ReadLine();
                    continue;
                }

                /// Split input
                string[] inputArr = input.Split("@".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                string singerName = inputArr[0].Trim();
                string[] concertInfo = inputArr[1].Trim().Split().ToArray();
                int ticketPrice = int.Parse(concertInfo[concertInfo.Length - 2]);
                int ticketCount = int.Parse(concertInfo[concertInfo.Length - 1]);
                long totalMoney = ticketCount * ticketPrice;

                string venue = string.Empty;
                for (int i = 0; i < concertInfo.Length - 2; i++)
                {
                    venue += " " + concertInfo[i];
                }

                venue = venue.Trim();

                /// Add data in dictionary
                if (!singerDict.ContainsKey(venue))
                {
                    singerDict[venue] = new Dictionary<string, long>();
                }

                if (!singerDict[venue].ContainsKey(singerName))
                {
                    singerDict[venue][singerName] = totalMoney;
                }
                else
                {
                    singerDict[venue][singerName] += totalMoney;
                }

                input = Console.ReadLine();
            }

            /// Print result
            foreach (var record in singerDict)
            {
                Console.WriteLine($"{record.Key}");
                Console.Write($"#  {string.Join("#  ", record.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key} -> {x.Value}\n"))}");
            }
        }
    }
}
namespace _11_Logs_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> ipUserDuration = new SortedDictionary<string, SortedDictionary<string, int>>(); //<user>, <<ip>, <duration>>

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string ip = input[0];
                string user = input[1];
                int duration = int.Parse(input[2]);

                if (!ipUserDuration.ContainsKey(user))
                {
                    ipUserDuration[user] = new SortedDictionary<string, int>();
                }

                if (!ipUserDuration[user].ContainsKey(ip))
                {
                    ipUserDuration[user][ip] = 0;
                }

                ipUserDuration[user][ip] += duration;
            }

            foreach (var userDict in ipUserDuration)
            {
                Console.WriteLine($"{userDict.Key}: {userDict.Value.Values.Sum()} [{string.Join(", ", userDict.Value.Keys)}]");
            }
        }
    }
}

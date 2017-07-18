using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string ip = input[0];
                string user = input[1];
                int duration = int.Parse(input[2]);

                if (!logs.ContainsKey(user))
                {
                    logs[user] = new SortedDictionary<string, int>();
                }

                if (!logs[user].ContainsKey(ip))
                {
                    logs[user].Add(ip, 0);
                }

                logs[user][ip] += duration;
            }

            foreach (var item in logs)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()} [{string.Join(", ", item.Value.Keys)}]");
            }
        }
    }
}

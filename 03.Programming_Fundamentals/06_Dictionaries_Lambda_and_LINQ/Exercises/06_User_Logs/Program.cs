using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class User_Logs
{
    static void Main(string[] args)
    {
        SortedDictionary<string, List<string>> users = new SortedDictionary<string, List<string>>();

        string command = "";

        while (true)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            command = input[0];

            if (command == "end")
            {
                break;
            }

            string ip = command.Substring(command.IndexOf('=') + 1);
            string user = input[2].Substring(input[2].LastIndexOf('=') + 1);

            List<string> IPs = new List<string>();
            IPs.Add(ip);

            if (!users.ContainsKey(user))
            {
                users[user] = IPs;
            }
            else
            {
                users[user].AddRange(IPs);
            }
        }

        foreach (var user in users)
        {
            Console.WriteLine(user.Key + ": ");

            List<string> IPs = user.Value;
            Dictionary<string, int> numberOfIPs = new Dictionary<string, int>();

            foreach (var ip in IPs)
            {
                if (!numberOfIPs.ContainsKey(ip))
                {
                    numberOfIPs[ip] = 1;
                }
                else
                {
                    numberOfIPs[ip] += 1;
                }
            }

            int count = numberOfIPs.Count;

            foreach (var ip in numberOfIPs)
            {
                count--;

                if (count > 0)
                {
                    Console.Write(ip.Key + " => " + ip.Value + ", ");
                }
                else
                {
                    Console.Write(ip.Key + " => " + ip.Value + ". ");
                }
            }

            Console.WriteLine();
        }
    }
}
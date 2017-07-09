namespace _09_User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogs
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> usersDict = new Dictionary<string, Dictionary<string, int>>();      //<user>, <<ip>, <count>>

            while (input != "end")
            {
                string[] logs = input.Split(new string[] { "IP=", " message=", " user=" }, StringSplitOptions.RemoveEmptyEntries);

                string ip = logs[0];
                string user = logs[2];

                if (!usersDict.ContainsKey(user))
                {
                    usersDict[user] = new Dictionary<string, int>();
                }

                if (!usersDict[user].ContainsKey(ip))
                {
                    usersDict[user][ip] = 0;
                }

                usersDict[user][ip]++;

                input = Console.ReadLine();
            }

            foreach (var user in usersDict.OrderBy(u => u.Key))
            {
                List<string> ipCounter = new List<string>();   

                foreach (var ip in user.Value)
                {
                    ipCounter.Add(string.Join(" => ", ip.Key, ip.Value));   //192.23.30.40 => 2
                                                                            //192.23.30.41 => 1
                                                                            //192.23.30.42 => 1
                }

                Console.WriteLine($"{user.Key}:\n{string.Join(", ", ipCounter)}."); //destroyer:
                                                                                    //192.23.30.40 => 2, 192.23.30.41 => 1, 192.23.30.42 => 1.
            }
        }
    }
}

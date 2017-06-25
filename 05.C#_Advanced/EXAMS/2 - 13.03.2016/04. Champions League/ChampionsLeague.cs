namespace _04.Champions_League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ChampionsLeague
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> teamWins = new Dictionary<string, int>();
            Dictionary<string, List<string>> teamOpponents = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "stop")
            {
                string[] inputArr = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                string team1 = inputArr[0];
                string team2 = inputArr[1];

                string[] goals1 = inputArr[2].Split(':');
                string[] goals2 = inputArr[3].Split(':');

                int team1goal1 = int.Parse(goals1[0]);
                int team2goal1 = int.Parse(goals1[1]);
                int team2goal2 = int.Parse(goals2[0]);
                int team1goal2 = int.Parse(goals2[1]);

                bool team1Win = false;
                bool team2Win = false;

                if ((team1goal1 + team1goal2) > (team2goal1 + team2goal2))
                {
                    team1Win = true;    //team1 win
                }
                else if ((team1goal1 + team1goal2) == (team2goal1 + team2goal2))
                {
                    if (team2goal1 < team1goal2)
                    {
                        team1Win = true;    //team1 win
                    }
                    else
                    {
                        team2Win = true;    //team2 win
                    }
                }
                else
                {
                    team2Win = true;    //team2 win
                }

                if (!teamWins.ContainsKey(team1))
                {
                    teamWins[team1] = 0;
                    teamOpponents[team1] = new List<string>();
                }

                if (!teamWins.ContainsKey(team2))
                {
                    teamWins[team2] = 0;
                    teamOpponents[team2] = new List<string>();
                }

                if (team1Win && !team2Win)
                {
                    teamWins[team1]++;
                    teamOpponents[team1].Add(team2);
                    teamOpponents[team2].Add(team1);
                }
                else
                {
                    teamWins[team2]++;
                    teamOpponents[team1].Add(team2);
                    teamOpponents[team2].Add(team1);
                }

                input = Console.ReadLine();
            }

            foreach (var item in teamWins.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"- Wins: {item.Value}");

                foreach (var i in teamOpponents)
                {
                    if (item.Key == i.Key)
                    {
                        Console.WriteLine($"- Opponents: {string.Join(", ", i.Value.OrderBy(x => x))}");
                    }
                }
            }
        }
    }
}

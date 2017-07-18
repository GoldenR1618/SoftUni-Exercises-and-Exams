namespace _03_Football_League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class FootballLeague
    {
        public static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();

            Dictionary<string, int> teamPoint = new Dictionary<string, int>();
            Dictionary<string, int> teamGoals = new Dictionary<string, int>();

            while (input != "final")
            {
                string[] comm = input.Split(' ');

                string encrTeamA = comm[0];
                string encrTeamB = comm[1];
                string[] scoreAB = comm[2].Split(':');

                int scoreA = int.Parse(scoreAB[0]);
                int scoreB = int.Parse(scoreAB[1]);

                int startA = encrTeamA.IndexOf(key) + key.Length;
                int endA = encrTeamA.LastIndexOf(key);
                int startB = encrTeamB.IndexOf(key) + key.Length;
                int endB = encrTeamB.LastIndexOf(key);

                string TeamA = Reverce(encrTeamA.Substring(startA, (endA - startA))).ToUpper();
                string TeamB = Reverce(encrTeamB.Substring(startB, (endB - startB))).ToUpper();

                int pointA = 0;
                int pointB = 0;

                if (scoreA > scoreB)
                {
                    pointA = 3;
                    pointB = 0;
                }
                else if (scoreA < scoreB)
                {
                    pointA = 0;
                    pointB = 3;
                }
                else
                {
                    pointA = 1;
                    pointB = 1;
                }

                if (!teamPoint.ContainsKey(TeamA))
                {
                    teamPoint[TeamA] = 0;
                }

                if (!teamPoint.ContainsKey(TeamB))
                {
                    teamPoint[TeamB] = 0;
                }

                teamPoint[TeamA] += pointA;
                teamPoint[TeamB] += pointB;

                if (!teamGoals.ContainsKey(TeamA))
                {
                    teamGoals[TeamA] = 0;
                }

                if (!teamGoals.ContainsKey(TeamB))
                {
                    teamGoals[TeamB] = 0;
                }

                teamGoals[TeamA] += scoreA;
                teamGoals[TeamB] += scoreB;

                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");
            int count = 1;

            foreach (var item in teamPoint.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{count}. {item.Key} {item.Value}");
                count++;
            }

            Console.WriteLine("Top 3 scored goals:");
            int count2 = 1;

            foreach (var index in teamGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (count2 > 3)
                {
                    break;
                }

                Console.WriteLine($"- {index.Key} -> {index.Value}");
                count2++;
            }
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
}

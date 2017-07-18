namespace TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] newTeam = Console.ReadLine().Split('-').ToArray();
                List<string> membersList = new List<string>();
                Team team = new Team();
                team.TeamName = newTeam[1];
                team.CreatorName = newTeam[0];
                team.Members = membersList;

                if (!teams.Select(x => x.TeamName).Contains(team.TeamName))
                {
                    if (!teams.Select(x => x.CreatorName).Contains(team.CreatorName))
                    {
                        teams.Add(team);
                        Console.WriteLine("Team {0} has been created by {1}!", newTeam[1], newTeam[0]);
                    }
                    else
                    {
                        Console.WriteLine("{0} cannot create another team!", team.CreatorName);
                    }
                }
                else
                {
                    Console.WriteLine("Team {0} was already created!", team.TeamName);
                }
            }

            string teamRegistration = Console.ReadLine();

            while (!teamRegistration.Equals("end of assignment"))
            {
                var split = teamRegistration.Split(new char[] { '-', '>' }).ToArray();
                string newUser = split[0];
                string teamName = split[2];

                if (!teams.Select(x => x.TeamName).Contains(teamName))
                {
                    Console.WriteLine("Team {0} does not exist!", teamName);
                }
                else if (teams.Select(x => x.Members).Any(x => x.Contains(newUser)) || teams.Select(x => x.CreatorName).Contains(newUser))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", newUser, teamName);
                }
                else
                {
                    int teamToJoinIndex = teams.FindIndex(x => x.TeamName == teamName);
                    teams[teamToJoinIndex].Members.Add(newUser);
                }

                teamRegistration = Console.ReadLine();
            }

            var teamsToDisband = teams.OrderBy(x => x.TeamName).Where(x => x.Members.Count == 0);
            var fullTeams = teams.
            OrderByDescending(x => x.Members.Count).
            ThenBy(x => x.TeamName).
            Where(x => x.Members.Count > 0);

            foreach (var team in fullTeams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.CreatorName}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var item in teamsToDisband)
            {
                Console.WriteLine(item.TeamName);
            }

        }
    }

    class Team
    {
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }
    }
}
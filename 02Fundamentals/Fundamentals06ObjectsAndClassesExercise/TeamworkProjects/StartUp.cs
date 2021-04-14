namespace TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class StartUp
    {
        static void Main()
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>(countOfTeams);
            for (int i = 0; i < countOfTeams; i++)
            {
                string[] currLine = Console.ReadLine().Split("-");
                string currTeamCreator = currLine[0];
                string currTeamName = currLine[1];
                if (Team.IsNewName(currTeamName, teams) != -1)
                {
                    Console.WriteLine($"Team {currTeamName} was already created!");
                    continue;
                }
                if (!Team.IsNewCreator(currTeamCreator, teams))
                {
                    Console.WriteLine($"{currTeamCreator} cannot create another team!");
                    continue;
                }
                Team team = new Team(currTeamCreator, currTeamName);
                teams.Add(team);
                Console.WriteLine($"Team {currTeamName} has been created by {currTeamCreator}!");
            }
            string commandLine = Console.ReadLine();
            while (commandLine != "end of assignment")
            {
                string[] command = commandLine.Split("->");
                string user = command[0];
                string joiningTeam = command[1];
                int index = Team.IsNewName(joiningTeam, teams);
                if (index == -1)
                {
                    Console.WriteLine($"Team {joiningTeam} does not exist!");
                    commandLine = Console.ReadLine();
                    continue;
                }
                if (Team.UserExists(user, teams))
                {
                    Console.WriteLine($"Member {user} cannot join team {joiningTeam}!");
                    commandLine = Console.ReadLine();
                    continue;
                }
                teams[index].Members.Add(user);
                commandLine = Console.ReadLine();
            }
            if (Team.IsTeamWithMembers(teams))
            {
                foreach (Team team in teams.Where(x => x.Members.Count != 1).OrderBy(y => y.Name).OrderByDescending(x => x.Members.Count))
                {
                    Console.WriteLine(team.ToString());
                }
            }
            Console.WriteLine("Teams to disband:");
            if (Team.IsTeamWithoutMembers(teams))
            {
                foreach (Team team in teams.Where(x => x.Members.Count == 1).OrderBy(y => y.Name))
                {
                    Console.WriteLine(team.Name);
                }
            }
        }
    }
    public class Team
    {
        public string Creator { get; set; }
        public string Name { get; set; }
        public List<string> Members { get; set; }
        public Team(string creator, string name)
        {
            Creator = creator;
            Name = name;
            Members = new List<string>
            {
                creator
            };
        }
        internal static bool IsNewCreator(string currCreator, List<Team> teams)
        {
            foreach (Team item in teams.Where(x => x.Creator == currCreator))
            {
                return false;
            }
            return true;
        }
        internal static int IsNewName(string currName, List<Team> teams)
        {
            foreach (Team item in teams.Where(x => x.Name == currName))
            {
                return teams.IndexOf(item);
            }
            return -1;
        }
        internal static bool UserExists(string user, List<Team> teams)
        {
            foreach (Team team in teams)
            {
                if (team.Members.Contains(user))
                {
                    return true;
                }
            }
            return false;
        }
        internal static bool IsTeamWithoutMembers(List<Team> teams)
        {
            foreach (var item in teams)
            {
                if (item.Members.Count == 1)
                {
                    return true;
                }
            }
            return false;
        }
        internal static bool IsTeamWithMembers(List<Team> teams)
        {
            foreach (var item in teams)
            {
                if (item.Members.Count != 1)
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder team = new StringBuilder();
            team.AppendLine($"{Name}");
            team.AppendLine($"- {Creator}");
            List<string> members = Members.Skip(1).ToList();
            members.Sort();
            foreach (var item in members)
            {
                team.AppendLine($"-- {item}");
            }
            return team.ToString().Trim();
        }
    }
}
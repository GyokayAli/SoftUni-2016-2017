namespace _09.TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TeamworkProjects
    {
        public static void Main()
        {
            var teamNumber = int.Parse(Console.ReadLine());

            var teamsList = new List<Team>();
            var messagesList = new List<string>();

            for (int i = 0; i < teamNumber; i++)
            {
                var input = Console.ReadLine().Split('-');
                var creator = input[0];
                var teamName = input[1];

                if (teamsList.Any(x => x.Name == teamName))
                {
                    messagesList.Add($"Team {teamName} was already created!");
                }
                else if (teamsList.Any(x => x.Creator == creator))
                {
                    messagesList.Add($"{creator} cannot create another team!");
                }
                else
                {
                    var team = new Team(teamName, creator, new List<string>());
                    messagesList.Add($"Team {teamName} has been created by {creator}!");
                    teamsList.Add(team);
                }
            }

            var inputLine = Console.ReadLine();

            while (inputLine != "end of assignment")
            {
                var input = inputLine.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var userName = input[0];
                var teamName = input[1];

                if (!teamsList.Any(x => x.Name == teamName))
                {
                    messagesList.Add($"Team {teamName} does not exist!");
                }
                else
                {
                    var currentTeam = teamsList.Where(x => x.Name == teamName).First();

                    if (teamsList.Exists(x => x.Creator == userName) || teamsList.Select(x => x.Members).Any(x => x.Contains(userName)))
                    {
                        messagesList.Add($"Member {userName} cannot join team {teamName}!");
                    }
                    else
                    {
                        currentTeam.Members.Add(userName);
                    }
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, messagesList));

            var teamsWithMembersList = teamsList
                .OrderByDescending(x => x.Members.Count())
                .ThenBy(x => x.Name)
                .Where(x => x.Members.Count > 0)
                .ToList();

            foreach (var team in teamsWithMembersList)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            var disbandTeamsList = teamsList
                  .OrderBy(x => x.Name)
                  .Where(x => x.Members.Count() == 0)
                  .ToList();

            Console.WriteLine("Teams to disband:");
            foreach (var team in disbandTeamsList)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}

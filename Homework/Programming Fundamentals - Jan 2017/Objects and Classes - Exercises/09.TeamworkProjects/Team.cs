namespace _09.TeamworkProjects
{
    using System.Collections.Generic;

    public class Team
    {
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public Team(string name, string creator, List<string> members)
        {
            Name = name;
            Creator = creator;
            Members = members;
        }
    }
}

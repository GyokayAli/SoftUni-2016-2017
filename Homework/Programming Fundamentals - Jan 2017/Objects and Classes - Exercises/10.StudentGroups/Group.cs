namespace _10.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }

        public static List<Town> ReadTownsAndStudents()
        {
            var towns = new List<Town>();

            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                if (inputLine.IndexOf("=>") != -1)
                {
                    Town town = new Town();
                    string[] parseInput = inputLine.Trim().Split(new[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

                    town.Name = parseInput[0];
                    town.SeatsCount = int.Parse(parseInput[1].Split(' ')[0]);
                    town.Students = new List<Student>();
                    towns.Add(town);
                }
                else
                {
                    Student student = new Student();
                    string[] parseInput = inputLine.Split(new[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    student.Name = parseInput[0] + " " + parseInput[1];
                    student.Email = parseInput[2];
                    if (parseInput[2].Contains("|"))
                    {
                        student.Email = student.Email.Substring(1, parseInput[2].Length - 1);
                    }
                    if (parseInput[3].Contains("|"))
                    {
                        parseInput[3] = parseInput[3].Substring(1, parseInput[3].Length - 1);
                    }

                    student.RegistrationDate = DateTime.ParseExact(parseInput[3], "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    towns[towns.Count - 1].Students.Add(student);
                }

                inputLine = Console.ReadLine();
            }

            return towns;
        }

        public static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (var town in towns.OrderBy(x => x.Name))
            {
                IEnumerable<Student> students =
                    town.Students.OrderBy(x => x.RegistrationDate).ThenBy(n => n.Name).ThenBy(e => e.Email);

                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }
            return groups;
        }
    }
}

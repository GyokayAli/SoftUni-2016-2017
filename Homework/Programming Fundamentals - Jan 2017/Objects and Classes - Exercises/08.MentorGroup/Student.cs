namespace _08.MentorGroup
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student
    {
        public string Name { get; set; }

        public List<string> Dates { get; set; }

        public List<string> Comments { get; set; }

        public Student(string name)
        {
            Name = name;
            Dates = new List<string>();
            Comments = new List<string>();
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendLine(Name);
            output.AppendLine("Comments:");

            foreach (var comment in Comments)
            {
                output.AppendLine($"- {comment}");
            }

            output.AppendLine("Dates attended:");
            foreach (var date in Dates.OrderBy(x => x))
            {
                output.AppendLine($"-- {date}");
            }

            return output.ToString().Trim();
        }
    }
}

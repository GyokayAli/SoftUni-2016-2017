namespace _08.MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MentorGroup
    {
        public static void Main()
        {
            var datesInput = Console.ReadLine();
            var studentsDictionary = new SortedDictionary<string, Student>();

            while (datesInput != "end of dates")
            {
                var tokens = datesInput.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                IEnumerable<string> dates = tokens.Skip(1);

                if (!studentsDictionary.ContainsKey(name))
                {
                    studentsDictionary[name] = new Student(name);
                }

                foreach (var date in dates)
                {
                    studentsDictionary[name].Dates.Add(date);
                }

                datesInput = Console.ReadLine();
            }

            string commentsInput = Console.ReadLine();

            while (commentsInput != "end of comments")
            {
                var tokens = commentsInput.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var comment = tokens[1];

                if (studentsDictionary.ContainsKey(name))
                {
                    studentsDictionary[name].Comments.Add(comment);
                }

                commentsInput = Console.ReadLine();
            }

            foreach (var student in studentsDictionary)
            {
                Console.WriteLine(student.Value);
            }
        }
    }
}

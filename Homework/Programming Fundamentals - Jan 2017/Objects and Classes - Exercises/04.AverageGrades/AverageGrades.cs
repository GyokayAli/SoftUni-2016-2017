namespace _04.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var studentsList = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                var studentName = input[0];
                input.Remove(studentName);

                var studentGrades = input.Select(double.Parse).ToArray();

                var student = new Student
                {
                    Name = studentName,
                    Grades = studentGrades
                };
                studentsList.Add(student);
            }

            //filtered and ordered list of students where average grade >= 5.00
            var resultStudentsList = studentsList
                .Where(x => x.AverageGrade >= 5)
                .OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade)
                .ToList();

            foreach (var student in resultStudentsList)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }
    }
}

//Solution thanks to: https://github.com/tuscann
namespace _10.StudentGroups
{
    using System;
    using System.Linq;

    public class StudentGroups
    {
        static void Main()
        {
            var tokens = Group.ReadTownsAndStudents();

            var result = Group.DistributeStudentsIntoGroups(tokens);
            Console.WriteLine($"Created {result.Count} groups in {result.Select(a => a.Town).Distinct().ToList().Count} towns:");

            foreach (var group in result)
            {
                Console.WriteLine($"{group.Town.Name} => {string.Join(", ", group.Students.Select(a => a.Email).ToList())}");
            }
        }
    }
}

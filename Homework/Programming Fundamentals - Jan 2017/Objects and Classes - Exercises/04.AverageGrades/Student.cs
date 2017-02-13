namespace _04.AverageGrades
{
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }

        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }
    }
}

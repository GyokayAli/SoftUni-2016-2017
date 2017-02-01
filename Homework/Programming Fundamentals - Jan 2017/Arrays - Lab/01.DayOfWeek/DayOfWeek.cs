namespace _01.DayOfWeek
{
    using System;

    class DayOfWeek
    {
        static void Main(string[] args)
        {
            int dayNo = int.Parse(Console.ReadLine());
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            var result = dayNo > 0 && dayNo <= 7 ? weekDays[dayNo - 1] : "Invalid Day!";

            Console.WriteLine(result);
        }
    }
}

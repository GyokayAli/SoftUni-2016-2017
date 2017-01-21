using System;

namespace _03.OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMin = int.Parse(Console.ReadLine());

            var dateNow = DateTime.Now;
            var examDate = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, examHour, examMin, 0);
            var arriveDate = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day, arriveHour, arriveMin, 0);

            var timeDiff = Math.Abs((examDate - arriveDate).TotalMinutes);
            TimeSpan ts = TimeSpan.FromMinutes(timeDiff);

            string message = "";

            if (arriveDate <= examDate)
            {
                if (timeDiff == 0)
                {
                    message = "On time";
                }
                else if (timeDiff <= 30)
                {
                    message = "On time\n" + timeDiff + " minutes before the start";
                }
                else
                {
                    if (timeDiff >= 60)
                    {
                        if (ts.Minutes < 10)
                        {
                            message = "Early\n" + ts.Hours + ":0" + ts.Minutes + " hours before the start";
                        }
                        else
                        {
                            message = "Early\n" + ts.Hours + ":" + ts.Minutes + " hours before the start";
                        }
                    }
                    else
                    {
                        message = "Early\n" + timeDiff + " minutes before the start";
                    }
                }
            }
            else
            {
                if (timeDiff >= 60)
                {
                    if (ts.Minutes < 10)
                    {
                        message = "Late\n" + ts.Hours + ":0:" + ts.Minutes + " hours after the start";
                    }
                    else
                    {
                        message = "Late\n" + ts.Hours + ":" + ts.Minutes + " hours after the start";
                    }
                }
                else
                {
                    message = "Late\n" + timeDiff + " minutes after the start";
                }
            }

            Console.WriteLine(message);
        }
    }
}

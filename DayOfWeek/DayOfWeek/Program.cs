using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the day of the week: ");
            string DayWeek = Console.ReadLine();
            DayWeek = DayWeek.Trim().ToLower();
            DayOfWeek day = DayOfWeek.Monday;
            bool DayNotExist = false;

                switch (DayWeek)
                {
                    case "mon" or "monday":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    day = DayOfWeek.Monday;
                    break;

                    case "tue" or "tuesday":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    day = DayOfWeek.Tuesday;
                    break;

                    case "wed" or "wednesday":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    day = DayOfWeek.Wednesday;
                    break;

                    case "thu" or "thursday":
                    Console.ForegroundColor = ConsoleColor.White;
                    day = DayOfWeek.Thursday;
                    break;

                    case "fri" or "friday":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    day = DayOfWeek.Friday;
                    break;

                    case "sat" or "saturday":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    day = DayOfWeek.Saturday;
                    break;

                    case "sun" or "sunday":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    day = DayOfWeek.Sunday;
                    break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("There is no such day of the week\n");
                    DayNotExist = true;
                        break;
                }

                if (DayNotExist == false)
                {
                    Console.Write($"{DayWeek}");

                    var BeforeTheWeekend = DayOfWeek.Saturday - day;
                    if ((BeforeTheWeekend < 0) || (BeforeTheWeekend > 5))
                    {
                        BeforeTheWeekend = 0;
                    }
                    Console.WriteLine($". Day week number is {(int)day}. There are {BeforeTheWeekend} days till the end of the week");
                    
                    var numderOfDaysOfTheWeek = 7;
                if (DateTime.Today.DayOfWeek == day)
                {
                    DateTime.Today.AddDays((int)DayOfWeek.Sunday);
                    Console.WriteLine($"Today is {DateTime.Today.DayOfWeek}, next day will be on {DateTime.Today.AddDays(numderOfDaysOfTheWeek).ToShortDateString()}");
                }
                    else
                    {
                        var diff = day - DateTime.Today.DayOfWeek;
                        if (diff < 0)
                        {
                            diff += numderOfDaysOfTheWeek;
                        }
                        Console.WriteLine($"Next week day {DayWeek} will be on {DateTime.Today.AddDays(diff).ToShortDateString()}");
                    }
                }
                Console.WriteLine();
        }

    }
}
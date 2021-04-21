using System;
using System.Globalization;

namespace Delegate
{
    public class Regular : Priority
    {
        public void EnterDateNTime()
        {
            Console.WriteLine("Enter date");

            string taskDate = Console.ReadLine();
            if (!String.IsNullOrEmpty(taskDate))
            {
                try
                {
                    Date = DateTime.Parse(taskDate, CultureInfo.CreateSpecificCulture("ru-ru"));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            else
            {
                Date = null;
            }


            Console.WriteLine("Enter time");

            string taskTime = Console.ReadLine();
            string[] time = taskTime.Split(':');

            if (!String.IsNullOrEmpty(taskTime))
            {
                try
                {
                    TimeWoDate = new DateTime(1, 1, 1, Int32.Parse(time[0]), Int32.Parse(time[1]), 0);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            else
            {
                TimeWoDate = null;
            }
        }
    }
}
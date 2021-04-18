using System;
using System.Globalization;


namespace ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {            
            HomeTask[] homeTasksArray = new HomeTask[0];
            int i = 0;
            do
            {
                HomeTask ht = EnterHomeTask(i);
                Array.Resize(ref homeTasksArray, homeTasksArray.Length + 1);
                homeTasksArray[i] = ht;
                i++;
                Console.WriteLine("Would you like to  enter new task press <Enter>,  or <.> to brake");
            }
            while (Console.ReadLine() != ".");
            Console.WriteLine("List of tasks");
            PrintHomeTasks(homeTasksArray);
            Console.ReadLine();
        }

        private static HomeTask EnterHomeTask(int i)
        {
            throw new NotImplementedException();
        }

        public static HomeTask(int number)
        {
            Console.WriteLine("Enter task {0}: ", number + 1);

            Console.WriteLine("Enter task name");
            string homeTask = Console.ReadLine();
            if (!String.IsNullOrEmpty(homeTask))
            {
                var taskname = homeTask;
            }
            return homeTask;
        }

        public static taskDateTime(DateTime? date, DateTime? time)
        {
            Console.WriteLine("Enter date");

            string taskDate = Console.ReadLine();
            if (!String.IsNullOrEmpty(taskDate))
            {
                try
                {
                    taskDate.date = DateTime.Parse(taskDate, CultureInfo.CreateSpecificCulture("ru-ru"));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            else
            {
                taskDate.date = null;
            }

            Console.WriteLine("Enter time");

            string taskTime = Console.ReadLine();
            string[] time = taskTime.Split(':');
            if (!String.IsNullOrEmpty(taskTime))
            {
                try
                {
                    taskTime.time = new DateTime(1, 1, 1, Int32.Parse(time[0]), Int32.Parse(time[1]), 0);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            else
            {
                taskTime.time = null;
            }
        }

        public static Priority()
        { 
            Console.WriteLine("Enter priority");

            string priority = Console.ReadLine();
            if (!String.IsNullOrEmpty(priority))
            {
                try
                {
                    priority.priority = Int32.Parse(priority);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            else
            {
                priority.priority = null;
            }
            return priority;
        }

        public static void PrintHomeTasks(HomeTask[] harr)
        {
            string date;
            string time;
            string priority;
            PrintTask(harr, out date, out time, out priority);
        }

        private static void PrintTask(HomeTask[] harr, out string date, out string time, out string priority)
        {
            for (int i = 0; i < harr.Length; i++)
            {
                if (harr[i].date == null)
                {
                    date = String.Empty;
                }
                else
                {
                    date = harr[i].date.Value.ToShortDateString();
                }

                if (harr[i].time == null)
                {
                    time = String.Empty;
                }
                else
                {
                    time = harr[i].time.Value.ToShortTimeString();
                }

                if (harr[i].priority == null)
                {
                    priority = String.Empty;
                }
                else
                {
                    priority = harr[i].priority.Value.ToString();
                }
                Console.WriteLine("{0} {1} {2} {3}", harr[i].taskname, date, time, priority);
            }
        }
    }
}
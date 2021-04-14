using System;
using System.Globalization;


namespace ConsoleApp
{
    class HomeTask
    {
        public string taskname;
        public DateTime? date;
        public DateTime? time;
        public int? priority;
    }

    class Program
    {
        static void Main(string[] args)
        {
            HomeTask ht = new HomeTask();
            HomeTask[] homeTasksArray = new HomeTask[0];
            int i = 0;
            do
            {
                ht = EnterHomeTask(i);
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

        public static HomeTask EnterHomeTask(int number)
        {
            Console.WriteLine("Enter task {0}: ", number + 1);
            HomeTask homeTask = new HomeTask();
            Console.WriteLine("Enter task name");
            string title = Console.ReadLine();
            if (!String.IsNullOrEmpty(title))
            {
                homeTask.taskname = title;
            }
            Console.WriteLine("Enter date");

            string taskDate = Console.ReadLine();
            if (!String.IsNullOrEmpty(taskDate))
            {
                try
                {
                    homeTask.date = DateTime.Parse(taskDate, CultureInfo.CreateSpecificCulture("ru-ru"));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            else
            {
                homeTask.date = null;
            }
            Console.WriteLine("Enter time");

            string taskTime = Console.ReadLine();
            string[] time = taskTime.Split(':');
            if (!String.IsNullOrEmpty(taskTime))
            {
                try
                {
                    homeTask.time = new DateTime(1, 1, 1, Int32.Parse(time[0]), Int32.Parse(time[1]), 0);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            else
            {
                homeTask.time = null;
            }

            Console.WriteLine("Enter priority");

            string pr = Console.ReadLine();
            if (!String.IsNullOrEmpty(pr))
            {
                try
                {
                    homeTask.priority = Int32.Parse(pr);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            else
            {
                homeTask.priority = null;
            }
            return homeTask;
        }

        public static void PrintHomeTasks(HomeTask[] harr)
        {
            string date;
            string time;
            string priority;

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
using System;
using System.Globalization;

namespace Delegate
{
    public class WeeklyTaskService
    {
        private static WeeklyTask[] weeklyTasks = new WeeklyTask[0];

        public void EnterTasks()
        {
            int i = 0;

            do
            {
                Array.Resize(ref weeklyTasks, weeklyTasks.Length + 1);
                Regular regular = new Regular();
                FillTask(regular, i);
                weeklyTasks[i] = regular;
                i++;
                Console.WriteLine("Would you like to enter new task press <Enter>, or <.> to brake");
            } while (Console.ReadLine() != ".");
        }

        private static void FillTask(Regular regular, int taskNumber)
        {
            regular.EnterTaskName(taskNumber);
            regular.EnterDateNTime();
            regular.EnterPriority();
        }

        public void PrintAllTasks()
        {
            for (int i = 0; i < weeklyTasks.Length; i++)
            {
                PrintOneTask(weeklyTasks[i], i);
            }
        }

        public void PrintOneTask(WeeklyTask weeklyTask, int numberOfTask)
        {
            string date = weeklyTask.Date == null ? String.Empty : weeklyTask.Date.Value.ToShortDateString();

            string time = weeklyTask.TimeWoDate == null ? String.Empty : weeklyTask.TimeWoDate.Value.ToShortTimeString();

            string priority = weeklyTask.Priority == null ? String.Empty : weeklyTask.Priority.Value.ToString();

            Console.WriteLine($"TaskN{numberOfTask + 1}: {weeklyTask.Taskname} {date} {time} {priority}");
        }

        public void PriorityFilter()
        {
            Console.WriteLine("To filter tasks by priority press Enter or other key to deny");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine();
                return;
            }

            Console.WriteLine("Enter priority");

            int priority;

            if (!Int32.TryParse(Console.ReadLine(), out priority))
            {
                Console.WriteLine("Wrong priority");
                return;
            }

            for (int i = 0; i < weeklyTasks.Length; i++)
            {
                if (weeklyTasks[i].Priority >= priority)
                {
                    PrintOneTask(weeklyTasks[i], i);
                }
            }
        }

        public void DateFilter()
        {
            Console.WriteLine("To filter tasks by date press Enter or other key to deny");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine();
                return;
            }

            Console.WriteLine("Enter date");

            string taskDate = Console.ReadLine();

            var date = DateTime.Parse(taskDate, CultureInfo.CreateSpecificCulture("ru-ru"));

            for (int i = 0; i < weeklyTasks.Length; i++)
            {
                if (weeklyTasks[i].Date >= date)
                {
                    PrintOneTask(weeklyTasks[i], i);
                }
            }
        }

        delegate void Message(int taskNumber);
        public void UpdateTask()
        {
            Console.WriteLine("To update task press Enter or other key to deny");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                return;
            }

            Message message = PrintMessage;

            Console.WriteLine("Enter task number");

            int taskNumber = 0;

            if (!Int32.TryParse(Console.ReadLine(), out taskNumber)
                || taskNumber > weeklyTasks.Length
                || taskNumber < 1)
            {
                Console.WriteLine("Wrong number of task");
                return;
            }

            var regular = new Regular();
            FillTask(regular, taskNumber - 1);
            weeklyTasks[taskNumber - 1] = regular;
            message(taskNumber);
        }

        private static void PrintMessage(int number)
        {
            Console.WriteLine($"Task #{number} has been updated"); 
        }
    }
}

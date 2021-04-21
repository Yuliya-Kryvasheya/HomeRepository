using System;

namespace Delegate
{
    public abstract class WeeklyTask
    {
        public string Taskname { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? TimeWoDate { get; set; }
        public int? Priority { get; set; }

        public void EnterTaskName(int number)
        {
            Console.WriteLine("Enter task {0}: ", number + 1);
            NewTaskName();
        }

        private void NewTaskName()
        {
            Console.WriteLine("Enter task name");
            string title = Console.ReadLine();
            if (!String.IsNullOrEmpty(title))
            {
                Taskname = title;
            }
        }
    }
}
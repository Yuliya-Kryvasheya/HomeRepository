using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegate;


namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskService = new WeeklyTaskService();

            taskService.EnterTasks();
            taskService.PrintAllTasks();
            taskService.UpdateTask();
            taskService.PrintAllTasks();
            taskService.PriorityFilter();
            taskService.DateFilter();

            Console.ReadLine();
        }
    }
}
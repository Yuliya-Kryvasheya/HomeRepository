using System;

namespace ConsoleApp
{
    abstract class HomeTask
    {
        private readonly string homeTask;
        
        public string taskname { get; set; }

        public HomeTask(string taskname)
        {
            _ = NewMethod();

            string NewMethod()
            {
                return homeTask;
            }
        }
    }
}
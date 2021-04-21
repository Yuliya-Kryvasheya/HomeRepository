using System;

namespace Delegate
{
    public class Priority : WeeklyTask
    {
        public void EnterPriority()
        {
            Console.WriteLine("Enter priority");
            string pr = Console.ReadLine();
            if (!String.IsNullOrEmpty(pr))
            {
                try
                {
                    Priority = Int32.Parse(pr);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            else
            {
                Priority = null;
            }
        }
    }
}
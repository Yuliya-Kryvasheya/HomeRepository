using System;


namespace ConsoleApp
{
    class taskDateTime
    {       
        private DateTime? taskDate;
        private DateTime? taskTime;
        
        public DateTime? date { get; set; }
        public DateTime? time { get; set; }
        
        public taskDateTime(DateTime? date, DateTime? time)
        {            
            date = taskDate;
            time = taskTime;
        }
    }
}
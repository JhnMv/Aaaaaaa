using System;

namespace Aaaaaaa {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("\"Employee Timekeeping System\"");
            Console.WriteLine("Date: " + DateTime.Today.ToShortDateString());
            Console.WriteLine();

            Console.Write("Please input your Employee ID number to time in: ");
            
            string employeeID = Console.ReadLine();

         // TimeSpan timeNow = DateTime.Now.TimeOfDay;
         // TimeSpan TimeIn = new TimeSpan(timeNow.Hours, timeNow.Minutes, timeNow.Seconds);
            TimeSpan TimeIn = new TimeSpan(8, 29, 0);
            
            Console.WriteLine("Employee " + employeeID + " login time is recorded: " + TimeIn);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine();

            Console.Write("Please input your Employee ID number to time out: ");
            employeeID = Console.ReadLine();
            
         
          // TimeSpan timeOut = new TimeSpan(timeNow.Hours, timeNow.Minutes, timeNow.Seconds);
            TimeSpan timeOut = new TimeSpan(21, 0, 0); 
            
            Console.WriteLine("Employee " + employeeID + " login time is recorded: " + timeOut);
            Console.WriteLine();

            TimeSpan lunchBreakDuration = new TimeSpan(1, 0, 0);
            TimeSpan totalHours = (timeOut - TimeIn) - lunchBreakDuration;
            
            Console.WriteLine("Total hours worked is: " + totalHours);
            
            TimeSpan regularHoursStart = new TimeSpan(8, 0, 0);
            TimeSpan regularHoursEnd = new TimeSpan(17, 0, 0);
            TimeSpan lateGracePeriod = new TimeSpan(8, 29, 59);
            TimeSpan lateIn = new TimeSpan(0, 0, 0);
            TimeSpan earlyOut = new TimeSpan(0, 0, 0);
            TimeSpan hoursLate = new TimeSpan(0, 0, 0);

            if (TimeIn > regularHoursStart) {
                lateIn = TimeIn - regularHoursStart;
            }
            
            if (timeOut < regularHoursEnd) {
                earlyOut = timeOut - regularHoursEnd;
            }

            if (TimeIn > lateGracePeriod) {
                hoursLate = TimeIn - regularHoursStart;
            }
            
            TimeSpan totalRegularHours = (totalHours) - (lateIn + earlyOut) ;
           

            Console.WriteLine("Total regular hours worked is: " + totalRegularHours);
            
            Console.WriteLine("Total hours late is: " + hoursLate);

        }
    }
}

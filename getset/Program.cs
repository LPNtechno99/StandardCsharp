using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.DateTime curTim = System.DateTime.Now;
            Time t1 = new Time(curTim);
            t1.DisplayTime();
            int theHour = t1.Hour;
            Console.WriteLine("Hour : {0}", theHour);
            theHour++;
            t1.Hour = theHour;
            Console.WriteLine("Hour update : {0}", t1.Hour);
            Console.ReadLine();
        }
    }
    public class Time
    {
        private int day, month, year, hour, minute, second;
        public void DisplayTime()
        {
            Console.WriteLine("Time Current : {0}/{1}/{2} {3}:{4}:{5}", day, month, year, hour, minute, second);
        }
        public Time(System.DateTime dt)
        {
            day = dt.Day;
            month = dt.Month;
            year = dt.Year;
            hour = dt.Hour;
            minute = dt.Minute;
            second = dt.Second;
        }
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }
    }
}

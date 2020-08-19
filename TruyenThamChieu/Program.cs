using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruyenThamChieu
{
    public class Program
    {
        static void Main(string[] agrs)
        {
            System.DateTime curTim = System.DateTime.Now;
            Time t1 = new Time(curTim);
            t1.DisplayTime();
            int theHour = 0, theMinute = 0, theSecond = 0;
            t1.GetTime(ref theHour, ref theMinute, ref theSecond);
            Console.WriteLine("Current Time : {0}:{1}:{2}", theHour, theMinute, theSecond);
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
        public void GetTime(ref int h, ref int m, ref int s)
        {
            h = hour;
            m = minute;
            s = second;
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
    }
}

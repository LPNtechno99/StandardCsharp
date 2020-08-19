using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Location loc1 = new Location(200,300);
            Console.WriteLine("loc 1 Location: {0}", loc1);
            Test t = new Test();
            t.myFunc(loc1);
            Console.WriteLine("loc 1 Location: {0}", loc1);
            Console.ReadLine();
        }
    }
    public struct Location
    {
        private int xVal;
        private int yVal;
        public Location(int xCoordinate, int yCoordinate)
        {
            xVal = xCoordinate;
            yVal = yCoordinate;
        }
        public int x
        {
            get
            {
                return xVal;
            }
            set
            {
                xVal = value;
            }
        }
        public int y
        {
            get
            {
                return yVal;
            }
            set
            {
                yVal = value;
            }
        }
        public override string ToString()
        {
            return String.Format("{0},{1}", xVal, yVal);
        }
    }
    public class Test
    {
        public void myFunc(Location loc)
        {
            loc.x = 50;
            loc.y = 100;
            Console.WriteLine("Loc 1 Location: {0}", loc);
        }
    }
}

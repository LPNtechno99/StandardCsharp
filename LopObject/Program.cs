using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopObject
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            Console.WriteLine("The value of i is: {0}",i.ToString());
            SomeClass s = new SomeClass(10);
            Console.WriteLine("The value of s is: {0}", s.ToString());
            Console.WriteLine("The value of 5 is: {0}",5.ToString());
            Console.ReadLine();
        }
    }
    public class SomeClass
    {
        protected int value;
        public SomeClass(int val)
        {
            value = val;
        }
        public override string ToString()
        {
            return value.ToString();
        }
    }
}

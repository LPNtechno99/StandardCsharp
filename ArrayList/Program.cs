using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_6_ArrayList_
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList empArr = new ArrayList();
            ArrayList intArr = new ArrayList();
            Random rd = new Random();
            for (int i = 0; i < 5; i++)
            {
                empArr.Add(new Employee(rd.Next(10) + 100));
                intArr.Add(rd.Next(10));
            }
            for (int i = 0; i < intArr.Count; i++)
            {
                Console.Write("{0} ", intArr[i].ToString());
            }
            Console.WriteLine("\n");
            for (int i = 0; i < empArr.Count; i++)
            {
                Console.Write("{0} ", empArr[i].ToString());
            }
            Console.WriteLine("\n");
            Console.WriteLine("empArr.Count: {0}", empArr.Count);
            Console.WriteLine("\n");
            Console.WriteLine("empArr.Capacity: {0}", empArr.Capacity);

            empArr.Sort();
            intArr.Sort();

            Console.WriteLine("\n");

            for (int i = 0; i < intArr.Count; i++)
            {
                Console.Write("{0} ", intArr[i].ToString());
            }
            Console.WriteLine("\n");
            for (int i = 0; i < empArr.Count; i++)
            {
                Console.Write("{0} ", empArr[i].ToString());
            }
            Console.ReadLine();

        }
    }
    public class Employee : IComparable
    {
        private int empID;
        public Employee(int empID)
        {
            this.empID = empID;
        }
        public override string ToString()
        {
            return empID.ToString();
        }
        public int EmpID
        {
            get
            {
                return empID;
            }
            set
            {
                empID = value;
            }
        }
        public int CompareTo(object obj)
        {
            Employee e = (Employee)obj;
            return this.empID.CompareTo(e.empID);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_7_InterfaceIComparer_
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList empArr = new ArrayList();
            Random rd = new Random();
            for (int i = 0; i < 5; i++)
            {
                empArr.Add(new Employee(rd.Next(10) + 100, rd.Next(20)));
            }
            for (int i = 0; i < empArr.Count; i++)
            {
                Console.WriteLine("\n{0}", empArr[i].ToString());
            }

            Console.WriteLine("\n");

            Employee.EmployeeComparer c = Employee.GetComparer();
            c.WhichComparision = Employee.EmployeeComparer.ComparisionType.EmpID;
            empArr.Sort(c);
            for (int i = 0; i < empArr.Count; i++)
            {
                Console.WriteLine("\n{0}", empArr[i].ToString());
            }

            Console.WriteLine("\n");

            c.WhichComparision = Employee.EmployeeComparer.ComparisionType.Yrs;
            empArr.Sort(c);
            for (int i = 0; i < empArr.Count; i++)
            {
                Console.WriteLine("\n{0}", empArr[i].ToString());
            }

            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
    public class Employee : IComparable
    {
        private int empID;
        private int yearOfsvc;
        public Employee(int empID)
        {
            this.empID = empID;
        }
        public Employee(int empID, int yearOfsvc)
        {
            this.empID = empID;
            this.yearOfsvc = yearOfsvc;
        }
        public override string ToString()
        {
            return "ID: " + empID.ToString() + ".Year of Svc: " + yearOfsvc.ToString();
        }
        public static EmployeeComparer GetComparer()
        {
            return new Employee.EmployeeComparer();
        }
        public int CompareTo(Object rhs)
        {
            Employee r = (Employee)rhs;
            return this.empID.CompareTo(r.empID);
        }
        public int CompareTo(Employee rhs, Employee.EmployeeComparer.ComparisionType which)
        {
            switch (which)
            {
                case EmployeeComparer.ComparisionType.EmpID:
                    return this.empID.CompareTo(rhs.empID);
                    break;
                case EmployeeComparer.ComparisionType.Yrs:
                    return this.yearOfsvc.CompareTo(rhs.yearOfsvc);
                    break;
                default:
                    break;
            }
            return 0;
        }
        public class EmployeeComparer:IComparer
        {
            public enum ComparisionType
            {
                EmpID,
                Yrs
            };
            public int Compare(object lhs, object rhs)
            {
                Employee left = (Employee)lhs;
                Employee right = (Employee)rhs;
                return left.CompareTo(right, WhichComparision);
            }
            public Employee.EmployeeComparer.ComparisionType whichComparision;
            public ComparisionType WhichComparision
            {
                get
                {
                    return whichComparision;
                }
                set
                {
                    whichComparision = value;
                }
            }
        }

    }
}

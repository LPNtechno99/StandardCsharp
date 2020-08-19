using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2_foreach_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[3];
            Employee[] empArray = new Employee[5];
            for (int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new Employee(i + 10);
            }
            foreach(Employee e in empArray)
            {
                Console.WriteLine(e.ToString() + "\t");
            }
            foreach(int i in intArray)
            {
                Console.WriteLine(i.ToString()+"\t");
            }
            Console.ReadLine();
        }
    }
    public class Employee
    {
        private int empID;
        private int size;
        public Employee(int empID)
        {
            this.empID = empID;
        }
        public override string ToString()
        {
            return empID.ToString();
        }
    }
}

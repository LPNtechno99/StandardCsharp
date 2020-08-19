using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Nam = new Student("Nam");
            Student Hanh = new Student("Hanh");

            Cat Mun = new Cat(5);
            Cat Muop = new Cat(3);

            Pair studentPair = new Pair(Nam, Hanh);
            Pair catPair = new Pair(Mun, Muop);

            Console.WriteLine("Sinh vien: \t\t\t {0}",studentPair.ToString());
            Console.WriteLine("Cat: \t\t {0}", catPair.ToString());

            Pair.WhichIsFirst theDelegate1 = new Pair.WhichIsFirst(Student.WhichStudentComesFirst);
            Pair.WhichIsFirst theDelegate2 = new Pair.WhichIsFirst(Cat.WhichCatComesFirst);
            Console.ReadKey();
        }
        public enum Comparison
        {
            theFirstComesFirst = 1,
            theSecondComesFirst = 2
        }
        public class Pair
        {
            private object[] thePair = new object[2];
            public delegate Comparison WhichIsFirst(object obj1, object obj2);
            public Pair(object firstObj, object secondObj)
            {
                thePair[0] = firstObj;
                thePair[1] = secondObj;
            }
            public void Sort(WhichIsFirst theDelegate)
            {
                if (theDelegate(thePair[0], thePair[1]) == Comparison.theSecondComesFirst)
                {
                    object temp = thePair[0];
                    thePair[0] = thePair[1];
                    thePair[1] = temp;
                }
            }
            public void ReverseSort(WhichIsFirst theDelegate)
            {
                if (theDelegate(thePair[0], thePair[1]) == Comparison.theFirstComesFirst)
                {
                    object temp = thePair[0];
                    thePair[0] = thePair[1];
                    thePair[1] = temp;
                }
            }
            public override string ToString()
            {
                return thePair[0].ToString() + "," + thePair[1].ToString();
            }
        }
        public class Cat
        {
            private int weight;
            public Cat(int weight)
            {
                this.weight = weight;
            }
            public static Comparison WhichCatComesFirst(object obj1, object obj2)
            {
                Cat c1 = (Cat)obj1;
                Cat c2 = (Cat)obj2;
                return c1.weight > c2.weight ? Comparison.theSecondComesFirst : Comparison.theFirstComesFirst;
            }
            public override string ToString()
            {
                return weight.ToString();
            }
        }
        public class Student
        {
            private string name;
            public Student(string name)
            {
                this.name = name;
            }
            public static Comparison WhichStudentComesFirst(object obj1, object obj2)
            {
                Student s1 = (Student)obj1;
                Student s2 = (Student)obj2;
                return (String.Compare(s1.name, s2.name) < 0 ? Comparison.theSecondComesFirst : Comparison.theFirstComesFirst);
            }
            public override string ToString()
            {
                return name;
            }
        }
    }
}

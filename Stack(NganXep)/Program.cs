using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack_NganXep_
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack intStack = new Stack();
            for (int i = 0; i < 5; i++)
            {
                intStack.Push(i * 5);
            }

            Console.Write("intStack Value: ");
            PrintValues(intStack);

            Console.WriteLine("\nPop\t{0}", intStack.Pop());
            Console.Write("\nintStack Value: ");
            PrintValues(intStack);

            Console.WriteLine("\nPop\t{0}", intStack.Pop());
            Console.Write("\nintStack Value: ");
            PrintValues(intStack);

            //Xem thành phần đầu tiên trong Stack
            Console.WriteLine("\nPeek\t{0}", intStack.Peek());

            //Khai báo mảng với 12 phần tử
            Array targetArr = Array.CreateInstance(typeof(int), 12);
            for (int i = 0; i <= 8; i++)
            {
                targetArr.SetValue(i * 100, i);
            }
            Console.WriteLine("\nTargetArr: \n");
            PrintValues(targetArr);

            //Sao chép toàn bộ Stack vào mảng tại vị trí 6
            intStack.CopyTo(targetArr, 6);
            Console.WriteLine("\nTargetArr after Copy: \n");
            PrintValues(targetArr);
            //Sao chép toàn bộ Stack sang mảng mới
            Object[] myArr = intStack.ToArray();
            Console.WriteLine("\nValue ArrayNew: \n");
            PrintValues(myArr);

            Console.ReadLine();
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            IEnumerator myEnumerator = myCollection.GetEnumerator();
            while (myEnumerator.MoveNext())
                Console.Write("{0} ", myEnumerator.Current);
            Console.WriteLine();
        }
    }
}

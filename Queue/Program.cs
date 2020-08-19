using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Hang_Doi_
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue intQueue = new Queue();
            for (int i = 0; i < 5; i++)
            {
                intQueue.Enqueue(i * 5);
            }
            Console.WriteLine("intQueue Values: \t");
            PrintQueue(intQueue);
            // xóa thành phần ra khỏi hàng đợi
            Console.WriteLine("\nDequeue\t { 0}", intQueue.Dequeue());
            // hiển thị hàng đợi
            Console.Write("intQueue values:\t");
            PrintQueue(intQueue);
            // xóa thành phần khỏi hàng đợi
            Console.WriteLine("\nDequeue\t { 0}", intQueue.Dequeue());
            // hiển thị hàng đợi
            Console.Write("intQueue values:\t");
            PrintQueue(intQueue);
            // Xem thành phần đầu tiên trong hàng đợi.
            Console.WriteLine("\nPeek \t { 0}", intQueue.Peek());
            // hiển thị hàng đợi
            Console.Write("intQueue values:\t");
            PrintQueue(intQueue);

            Console.ReadLine();
        }

        public static void PrintQueue(IEnumerable myCollection)
        {
            IEnumerator myEnumrator = myCollection.GetEnumerator();
            while(myEnumrator.MoveNext())
            {
                Console.Write("{0} ", myEnumrator.Current);
               
            }
            Console.WriteLine();
        }
    }
}

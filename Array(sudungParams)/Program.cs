using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_sudungParams_
{
    class Program
    {
        static void Main(string[] args)
        {
            Program t = new Program();
            t.DisplayVals(5, 6, 7, 8);
            int[] explicitArray = new int[] { 1, 2, 3, 4 };
            t.DisplayVals(explicitArray);
            Console.ReadLine();
        }
        public void DisplayVals(params int[] intVals) //từ khóa params cho phép chúng ta truyền một số biến của tham số mà không cần thiết phải tạo 1 mảng mới
        {
            foreach(int i in intVals)
            {
                Console.WriteLine("DisplayVals {0}", i);
            }
        }
    }
}

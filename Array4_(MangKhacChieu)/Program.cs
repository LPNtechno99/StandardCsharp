using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array4__MangKhacChieu_
{
    class Program
    {
        static void Main(string[] args)
        {
            const int rows = 4;
            int[][] jaggedArray = new int[rows][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[2];
            jaggedArray[2] = new int[3];
            jaggedArray[3] = new int[5];

            jaggedArray[0][2] = 10;
            jaggedArray[0][3] = 11;
            jaggedArray[1][0] = 20;
            jaggedArray[1][1] = 21;
            jaggedArray[2][0] = 30;
            jaggedArray[2][2] = 31;
            jaggedArray[3][3] = 100;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("jaggedArray[0][{0}] = {1}", i, jaggedArray[0][i]);
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("jaggedArray[1][{0}] = {1}", i, jaggedArray[1][i]);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("jaggedArray[2][{0}] = {1}", i, jaggedArray[2][i]);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("jaggedArray[1][{0}] = {1}", i, jaggedArray[3][i]);
            }
            Console.ReadLine();
        }
    }
}

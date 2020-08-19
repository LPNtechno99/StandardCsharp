using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_3_Mang2chieu_
{
    class Program
    {
        static void Main(string[] args)
        {
            const int rows = 4;
            const int columns = 3;
            int[,] rectangulerArray = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    rectangulerArray[i, j] = i + j;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("rectangulerArray[{0},{1}] = {2} ", i, j, rectangulerArray[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_1_KhaiNiemChiMuc_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minh hoa Indexer:");

            Indexer id = new Indexer();
            id[0] = "An";
            id[1] = "Binh";
            id[2] = "Hanh";
            id[3] = "Phuc";
            id[4] = "Giai";
            id[5] = "Thoat";
            id[6] = "Ra";
            for (int i = 0; i < Indexer.size; i++)
            {
                Console.WriteLine("{0}", id[i]);
            }
            Console.ReadKey();
        }
    }
    public class Indexer
    {
        public static int size = 10;
        private string[] nameList = new string[size];
        public Indexer()
        {
            for (int i = 0; i < size; i++)
            {
                nameList[i] = "none " + i;
            }
        }
        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index < size - 1)
                {
                    tmp = nameList[index];
                }
                else
                {
                    tmp = "";
                }
                return tmp;
            }
            set
            {
                if (index >= 0 && index < size - 1)
                {
                    nameList[index] = value;
                }
            }
        }
    }
}

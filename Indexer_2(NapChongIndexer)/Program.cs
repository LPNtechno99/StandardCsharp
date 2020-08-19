using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_2_NapChongIndexer_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minh Hoa Override Indexer");
            Console.WriteLine(".........................");
            IndexerOverride ido = new IndexerOverride();
            ido[0] = "Dich";
            ido[1] = "Cum";
            ido[2] = "Co";
            ido[3] = "Ro";
            ido[4] = "Na";
            ido[5] = "20";
            ido[6] = "19";
            for (int i = 0; i < IndexerOverride.size; i++)
            {
                Console.WriteLine("{0}", ido[i]);
            }
            Console.WriteLine(ido["Co"]);
            Console.ReadLine();
        }
    }
    class IndexerOverride
    {
        public static int size = 10;
        private string[] nameList = new string[size];
        public IndexerOverride()
        {
            for (int i = 0; i < size - 1; i++)
            {
                nameList[i] = "N/A";
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
        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < size)
                {
                    if(nameList[index]==name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }
    }
}

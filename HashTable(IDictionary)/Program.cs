using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable_IDictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("001", "Phuong Nam");
            hashTable.Add("002","My Hanh");
            hashTable.Add("003", "Marine");

            Console.WriteLine("hashTable[Marine]: {0}\n", hashTable["002"]);
            ICollection keys = hashTable.Keys;
            ICollection values = hashTable.Values;
            foreach(string s in keys)
            {
                Console.Write("\n{0} \n", s);
            }
            foreach (string s in values)
            {
                Console.Write("\n{0} \n", s);
            }
            Console.ReadLine();
        }
    }
}

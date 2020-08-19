using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_IDictionaryEnumerator_
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("001", "Phuong Nam");
            hashTable.Add("002", "My Hanh");
            hashTable.Add("003", "Marine");

            Console.WriteLine("hashTable");
            Console.WriteLine("Count:\t{0}",hashTable.Count);
            Console.WriteLine("Keys and Values: \n");
            PrintHashTable(hashTable);
            Console.ReadKey();
        }

        private static void PrintHashTable(Hashtable hashTable)
        {
            IDictionaryEnumerator enumerator = hashTable.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine("{0}:\t{1}", enumerator.Key, enumerator.Value);
            }
            Console.WriteLine();
        }
    }
}

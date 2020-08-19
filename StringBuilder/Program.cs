using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Mot, Hai, Ba, Bon Trung Tam Dao Tao CNTT";
            const char Space = ' ';
            const char Comma = ',';
            char[] delimiters = new char[]
            {
                Space,
                Comma
            };
            int ctr = 1;
            StringBuilder output = new StringBuilder();
            foreach(string substring in s1.Split(delimiters))
            {
                output.AppendFormat("{0}: {1}\n", ctr++, substring);
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}

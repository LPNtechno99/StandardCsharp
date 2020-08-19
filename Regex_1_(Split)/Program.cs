using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_1__Split_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Mot, Hai, Ba, Bon, Trung Tam Dao Tao CNTT";
            StringBuilder sBuilder = new StringBuilder();
            int id = 1;
            foreach (string subStr in Regex.Split(s1, " |, "))
            {
                sBuilder.AppendFormat("{0}: {1}\n", id++, subStr);
            }
            Console.WriteLine("{0}", sBuilder);
            Console.ReadLine();
        }
    }
}

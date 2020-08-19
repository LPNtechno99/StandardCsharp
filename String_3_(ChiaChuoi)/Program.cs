using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_3__ChiaChuoi_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Mot, Hai, Ba Trung Tam Dao Tao CNTT";
            const char space = ' ';
            const char comma = ',';
            char[] delimiters = new char[]
            {
                space,
                comma
            };
            string outputString = "";
            int ctr = 1;
            string[] s2 = s1.Split(delimiters);
            foreach(string substring in s2)
            {
                outputString += ctr++;
                //ctr++;
                outputString += ": ";
                outputString += substring;
                outputString += "\n";
            }
            Console.WriteLine(outputString);
            Console.ReadLine();
        }
    }
}

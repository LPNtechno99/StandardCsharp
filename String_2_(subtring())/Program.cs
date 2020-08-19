using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_2__subtring___
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Mot Hai Ba Bon";
            int ix;
            ix = s1.LastIndexOf(" ");
            string s2 = s1.Substring(ix + 1);
            s1 = s1.Substring(0, ix);
            ix = s1.LastIndexOf(" ");
            string s3 = s1.Substring(ix + 1);
            s1 = s1.Substring(0, ix);
            Console.WriteLine("s2: {0}", s2);
            Console.WriteLine("s3: {0}", s3);
            Console.ReadLine();
        }
    }
}

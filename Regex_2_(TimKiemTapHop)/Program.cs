using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_2__TimKiemTapHop_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Ngon Ngu Lap Trinh C Sharp ";
            //Tìm bất cứ chuỗi con nào KHÔNG CÓ KHOẢNG TRẮNG BÊN TRONG và KẾT THÚC LÀ KHOẢNG TRẮNG
            Regex theRex = new Regex(@"(\S+)\s");
            MatchCollection theMatches = theRex.Matches(s1);
            foreach (Match theMatch in theMatches)
            {
                Console.WriteLine("Chieu dai: {0}", theMatch.Length);
                if (theMatch.Length != 0)
                {
                    Console.WriteLine("Chuoi: {0}", theMatch.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}

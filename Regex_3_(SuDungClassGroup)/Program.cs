using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_3__SuDungClassGroup_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "10:10:30 192.168.1.100 google.com.vn " + "12:15:30 127.0.0.0 microsoft.com " + "23:05:40 169.189.0.20 halcon.net ";
            //Nhóm thời gian bằng một hay nhiều con số hay dấu : và theo sau bởi khoảng trắng
            //địa chỉ ip là một hay nhiều con số hay dấu . theo sau là khoảng trắng
            //địa chỉ web là một hay nhiều kí tự
            Regex rex = new Regex(@"(?<time>(\d|\:)+)\s" + @"(?<ip>(\d|\.)+)\s" + @"(?<site>\S+)");
            MatchCollection theMatch = rex.Matches(s1);
            int ctr = 0;
            foreach (Match match in theMatch)
            {
                ctr++;
                if (match.Length != 0)
                {
                    Console.WriteLine("\nChuoi match {0} : {1}",ctr, match.ToString());
                    Console.WriteLine("\nTime: {0}", match.Groups["time"]);
                    Console.WriteLine("\nIP: {0}", match.Groups["ip"]);
                    Console.WriteLine("\nWebsite: {0}", match.Groups["site"]);
                }
            }
            Console.ReadLine();
        }
    }
}

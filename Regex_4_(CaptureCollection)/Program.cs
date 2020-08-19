using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_4__CaptureCollection_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "12:30:45 IBM 127.0.0.0 DELL ";
            Regex reg = new Regex(@"(?<time>(\d|\:)+)\s" + @"(?<company>\S+)\s" + @"(?<ip>(\d|\.)+)\s" + @"(?<company>\S+)\s");
            MatchCollection theMatches = reg.Matches(s1);
            foreach(Match match in theMatches)
            {
                if(match.Length!=0)
                {
                    Console.WriteLine("match: {0}",match.ToString());
                    Console.WriteLine("Time: {0}",match.Groups["time"]);
                    Console.WriteLine("IP: {0}",match.Groups["ip"]);
                    Console.WriteLine("Company: {0}",match.Groups["company"]);
                    foreach(Capture cap in match.Groups["company"].Captures)
                    {
                        Console.WriteLine("Capture: {0}", cap.ToString());
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

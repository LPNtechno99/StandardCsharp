using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abcd";
            string s2 = "ABCD";
            string s3 = @"Trung Tam Dao Tao CNTT Thanh Pho Ha Noi Viet Nam";
            int result;
            result = string.Compare(s1, s2);
            Console.WriteLine("So Sanh 2 chuoi s1 {0}, chuoi s2 {1}: Ket qua {2}", s1, s2, result);
            result = string.Compare(s1, s2, true);
            Console.WriteLine("So Sanh 2 chuoi s1 {0}, chuoi s2 {1}: Ket qua {2}", s1, s2, result);
            string s4 = string.Concat(s1, s2);
            Console.WriteLine("Chuoi ket hop Concat s1 va s2: {0}", s4);
            string s5 = s1 + s2;
            Console.WriteLine("Chuoi ket hop nap chong toan tu: {0}", s5);
            string s6 = string.Copy(s5);
            Console.WriteLine("Chuoi s6 duoc copy tu s5: {0}", s6);
            string s7 = s6;
            Console.WriteLine("s6.Equal(s7): {0}", s6.Equals(s7));
            Console.WriteLine("string.Equal(s6,s7): {0}", string.Equals(s6, s7));
            Console.WriteLine("s6==s7: {0}", s6 == s7);
            Console.WriteLine("Chieu dai cua chuoi s7 la: {0}", s7.Length);
            Console.WriteLine("Phan tu thu 3 cua chuoi s7 la: {0}", s7[2]);
            Console.WriteLine("\nChuoi {0} ket thuc voi CNTT: {1}", s3, s3.EndsWith("CNTT"));
            Console.WriteLine("\nChuoi {0} ket thuc voi Nam: {1}", s3, s3.EndsWith("Nam"));
            Console.WriteLine("Vi tri dau tien cua chu CNTT: {0}", s3.IndexOf("CNTT"));
            string s8 = s3.Insert(18, "nhan luc ");
            Console.WriteLine("Chuoi s8: {0}", s8);
            string s9 = s3.Insert(s3.IndexOf("CNTT"), "nhan luc ");
            Console.WriteLine("Chuoi s8: {0}", s9);
            Console.ReadLine();
        }
    }
}

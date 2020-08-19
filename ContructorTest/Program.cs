using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructorTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.DateTime currentTime = System.DateTime.Now;
            ThoiGian t = new ThoiGian(currentTime);
            t.ThoiGianHienTai();
        }
    }
    public class ThoiGian
    {
        int Ngay, Thang, Nam, Gio, Phut, Giay;
        public void ThoiGianHienTai()
        {
            Console.WriteLine("Thoi gian hien tai la: {0}/{1}/{2} {3}:{4}:{5}", Ngay, Thang, Nam, Gio, Phut, Giay);
            Console.ReadLine();
        }
        public ThoiGian(System.DateTime dt)
        {
            Ngay = dt.Day;
            Thang = dt.Month;
            Nam = dt.Year;
            Gio = dt.Hour;
            Phut = dt.Minute;
            Giay = dt.Second;
        }
    }
}

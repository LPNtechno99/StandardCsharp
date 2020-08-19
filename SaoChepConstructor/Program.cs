using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaoChepConstructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.DateTime currTim = System.DateTime.Now;
            ThoiGian t1 = new ThoiGian(currTim);
            t1.ThoiGianHienTai();

            ThoiGian t2 = new ThoiGian(t1);
            t2.ThoiGianHienTai();
            Console.ReadLine();
        }
    }
    public class ThoiGian
    {
        int Ngay, Thang, Nam, Gio, Phut, Giay;
        long TichTac;
        public void ThoiGianHienTai()
        {
            Console.WriteLine("Thoi gian hien tai la: {0}/{1}/{2} {3}:{4}:{5}:{6}", Ngay, Thang, Nam, Gio, Phut, Giay, TichTac);
        }
        public ThoiGian(ThoiGian tg)
        {
            Ngay = tg.Ngay;
            Thang = tg.Thang;
            Nam = tg.Nam;
            Gio = tg.Gio;
            Phut = tg.Phut;
            Giay = tg.Giay;
            TichTac = tg.TichTac;
        }
        public ThoiGian(DateTime dt)
        {
            Ngay = dt.Day;
            Thang = dt.Month;
            Nam = dt.Year;
            Gio = dt.Hour;
            Phut = dt.Minute;
            Giay = dt.Second;
            TichTac = dt.Ticks;
        }
    }
}

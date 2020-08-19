using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_4_ThamChieuKieuDuLieuGiaTri_
{
    class Program
    {
        static void Main(string[] args)
        {
            myStruct theStruct = new myStruct();
            theStruct.Status = -1;
            Console.WriteLine("theStruct.Status: {0}", theStruct.Status);
            Console.WriteLine("\n");
            theStruct.Status = 2;
            Console.WriteLine("Change value...");
            Console.WriteLine("theStruct.Status: {0}", theStruct.Status);
            Console.WriteLine("\n");
            IStorable isStruct = (IStorable)theStruct;
            isStruct.Status = 4;
            Console.WriteLine("isStruct.Status: {0}, theStruct.Status: {1}", isStruct.Status, theStruct.Status);
            Console.WriteLine("\n");
            theStruct.Status = 6;
            Console.WriteLine("isStruct.Status: {0}, theStruct.Status: {1}", isStruct.Status, theStruct.Status);
            Console.ReadLine();
        }
    }
    interface IStorable
    {
        void Read();
        int Status { get; set; }
    }
    public struct myStruct:IStorable
    {
        private int status;
        public void Read()
        {
            Console.WriteLine("Implementing IStorable.Read");
        }
        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }
}

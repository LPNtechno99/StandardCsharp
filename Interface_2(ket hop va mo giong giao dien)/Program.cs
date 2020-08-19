using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2_ket_hop_va_mo_giong_giao_dien_
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("Hello! This is Document");

            IStorable isDoc = doc as IStorable;
            if(isDoc !=null)
            {
                isDoc.Read();
            }
            else
            {
                Console.WriteLine("IStorable not support");
            }

            ICompressible icDoc = doc as ICompressible;
            if(icDoc!=null)
            {
                icDoc.Compress();
            }
            else
            {
                Console.WriteLine("ICompressible not support");
            }

            ILoggedCompressible ilcDoc = doc as ILoggedCompressible;
            if(ilcDoc!=null)
            {
                ilcDoc.LogSavedByte();
                ilcDoc.Compress();
            }
            else
            {
                Console.WriteLine("ILoggedCompressible not support");
            }
            IStorableCompressible iscDoc = doc as IStorableCompressible;
            if(iscDoc!=null)
            {
                iscDoc.LogSavedByte();
                iscDoc.LogOriginalSize();
                iscDoc.Compress();
                iscDoc.Read();
            }
            else
            {
                Console.WriteLine("IStorableCompressible not support");
            }

            IEncryptable ieDoc = doc as IEncryptable;
            if(ieDoc!=null)
            {
                ieDoc.Encrypt();
            }
            else
            {
                Console.WriteLine("Encrypt not support");
            }
            Console.ReadLine();
        }
    }
    interface IStorable
    {
        void Read();
        void Write(object obj);
        int Status { get; set; }
    }
    interface ICompressible
    {
        void Compress();
        void Decompress();
    }
    //Mở rộng giao diện
    interface ILoggedCompressible : ICompressible
    {
        void LogSavedByte();
    }
    //Kết hợp giao diện
    interface IStorableCompressible : IStorable, ILoggedCompressible
    {
        void LogOriginalSize();
    }
    interface IEncryptable
    {
        void Encrypt();
        void Decrypt();
    }
    public class Document:IStorableCompressible,IEncryptable
    {
        private int status = 0;
        public Document(string s)
        {
            Console.WriteLine("Create Document with: {0}",s);
        }
        public void Read()
        {
            Console.WriteLine("Implementing Read method");
        }
        public void Write(object obj)
        {
            Console.WriteLine("Implementing Write method: {0}", obj);
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
        public void Compress()
        {
            Console.WriteLine("Implementing Compress method");
        }
        public void Decompress()
        {
            Console.WriteLine("Implementing Decompress method");
        }
        public void LogSavedByte()
        {
            Console.WriteLine("Implementing LogSavedByte method");
        }
        public void LogOriginalSize()
        {
            Console.WriteLine("Implementing LogOriginalSize method");
        }
        public void Encrypt()
        {
            Console.WriteLine("Implementing Encrypt method");
        }
        public void Decrypt()
        {
            Console.WriteLine("Implementing Decrypt method");
        }
    }
}

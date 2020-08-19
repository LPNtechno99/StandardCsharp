using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("Test Document");
            doc.Status = -1;
            doc.Read();
            Console.WriteLine("Document Status: {0}", doc.Status);
            IStorable isDoc = (IStorable)doc;
            isDoc.Status = 1;
            isDoc.Read();
            Console.WriteLine("IStorable Status: {0}", isDoc.Status);
            Console.ReadLine();
        }
    }
    interface IStorable
    {
        void Read();
        void Write(object obj);
        int Status
        {
            get; set;
        }
    }
    public class Document:IStorable
    {
        private int status=0;
        public Document(string s)
        {
            Console.WriteLine("Creating document with: {0}",s);
        }
        public void Read()
        {
            Console.WriteLine("Implementing the Read method for IStorable");
        }
        public void Write(object obj)
        {
            Console.WriteLine("Implementing the Write for IStorable {0}", obj);
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

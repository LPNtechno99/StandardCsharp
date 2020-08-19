using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_3_ThucThiTuongMinh_
{
    class Program
    {
        static void Main(string[] args)
        {
            Document theDoc = new Document("Test Document");
            IStorable isDoc = theDoc as IStorable;
            if(isDoc!=null)
            {
                isDoc.Read();
            }
            ITalk itDoc = theDoc as ITalk;
            if(itDoc!=null)
            {
                itDoc.Read();
            }
            theDoc.Read();
            theDoc.Talk();
            Console.ReadLine();
        }
    }
    interface IStorable
    {
        void Read();
        void Write();

    }
    interface ITalk
    {
        void Read();
        void Talk();
    }
    public class Document : IStorable, ITalk
    {
        public Document(string s)
        {
            Console.WriteLine("Create document with: {0}", s);
        }
        public virtual void Read()
        {
            Console.WriteLine("Implementing IStorable.Read");
        }
        public void Write()
        {
            Console.WriteLine("Implementing IStorable.Write");
        }
        void ITalk.Read()
        {
            Console.WriteLine("Implementing ITalk.Read");
        }
        public void Talk()
        {
            Console.WriteLine("Implementing ITalk.Talk");
        }
    }
}

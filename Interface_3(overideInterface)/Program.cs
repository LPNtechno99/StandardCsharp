using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_3_overideInterface_
{
    class Program
    {
        static void Main(string[] args)
        {
            Document theNote = new Note("Test Note");

            IStorable isNote = theNote as IStorable;
            if(isNote!=null)
            {
                isNote.Read();
                isNote.Write();
            }
            Console.WriteLine("\n");

            theNote.Read();
            theNote.Write();

            Console.WriteLine("\n");

            Note note2 = new Note("Note 2");

            Console.WriteLine("\n");

            IStorable isNote2 = note2 as IStorable;
            if(isNote!=null)
            {
                isNote2.Read();
                isNote2.Write();
            }
            note2.Read();
            note2.Write();
            Console.ReadLine();
        }
    }
    interface IStorable
    {
        void Read();
        void Write();
    }
    public class Document:IStorable
    {
        public Document(string s)
        {
            Console.WriteLine("Create Document with: {0}", s);
        }
        public virtual void Read()
        {
            Console.WriteLine("Document Read Method for IStorable");
        }
        public void Write()
        {
            Console.WriteLine("Document Write Method for IStrorable");
        }
    }
    public class Note:Document
    {
        public Note(string s):base(s)
        {
            Console.WriteLine("Create Note with: {0}", s);
        }
        public override void Read()
        {
            Console.WriteLine("Overriding the Read Method for Note");
        }
        public void Write()
        {
            Console.WriteLine("Implementing Write Method for Note");
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_5_Interface_IEnumerable_
{
    class Program
    {
        static void Main(string[] args)
        {
            ListBoxTest lbt = new ListBoxTest("Hi", "Everybody");
            lbt.Add("What");
            lbt.Add("Is");
            lbt.Add("The");
            lbt.Add("C");
            lbt.Add("Sharp");
            string subt = "Universe";
            lbt[1] = subt;
            int count = 1;
            foreach(string s in lbt)
            {
                Console.WriteLine("Value {0}: {1}", count, s);
                count++;
            }
            Console.ReadLine();
        }
    }
    public class ListBoxTest : IEnumerable
    {
        private string[] stringS;
        private int ctr;
        public class ListBoxEnumerator : IEnumerator
        {
            private int index;
            private ListBoxTest lbt;

            public ListBoxEnumerator(ListBoxTest lbt)
            {
                this.lbt = lbt;
                index = -1;
            }
            public bool MoveNext()
            {
                index++;
                if (index >= lbt.stringS.Length)
                {
                    return false;
                }
                else
                    return true;
            }
            public void Reset()
            {
                index = -1;
            }
            public object Current
            {
                get
                {
                    return (lbt[index]);
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)new ListBoxEnumerator(this);
        }
        public ListBoxTest(params string[] initStr)
        {
            stringS = new String[10];
            foreach(string s in initStr)
            {
                stringS[ctr++] = s;
            }
        }
        public void Add(string theString)
        {
            stringS[ctr] = theString;
            ctr++;
        }
        public string this[int index]
        {
            get
            {
                if(index <0 || index >=stringS.Length)
                {

                }
                return stringS[index];
            }
            set
            {
                stringS[index] = value;
            }
        }
        public int GetNumEntries()
        {
            return ctr;
        }
    }
}

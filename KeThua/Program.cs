using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    public class Program
    {
        static void Main(string[] args)
        {
            Window wd = new Window(4, 5);
            wd.DrawWindow();
            ListBox lb = new ListBox(20, 30, "Hi everyone");
            lb.DrawWindow();
            Console.ReadLine();
        }
    }
    public class Window
    {
        private int top, left;
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        public void DrawWindow()
        {
            Console.WriteLine("Draw Window at {0},{1}", top, left);
        }
    }
    public class ListBox : Window
    {
        private string mListBoxContent;
        public ListBox(int top, int left, string theContents):base(top,left)
        {
            mListBoxContent = theContents;
        }
        public new void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("ListBox Write : {0}", mListBoxContent);
        }
    }
}

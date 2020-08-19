using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhDaDinh_polymorph_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Window wd = new Window(3,4);
            ListBox lb = new ListBox(5,6,"Hello! I'm ListBox");
            Button bt = new Button(7, 8);
            wd.DrawWindow();
            lb.DrawWindow();
            bt.DrawWindow();
            Window[] windowArray = new Window[3];
            windowArray[0] = new Window(1,2);
            windowArray[1] = new ListBox(20,30,"ListBox right here!");
            windowArray[2] = new Button(40, 50);
            for(int i=0;i<3;i++)
            {
                windowArray[i].DrawWindow();
            }
            Console.ReadLine();
        }
    }
    public class Window
    {
        protected int top;
        protected int left;
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: Drawing Window at {0}, {1}", top, left);
        }
    }
    public class ListBox : Window
    {
        protected string listboxContent;
        public ListBox(int top, int left, string Contents) : base(top, left)
        {
            listboxContent = Contents;
        }
        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Writing string Listbox: {0}", listboxContent);
        }
    }
    public class Button : Window
    {
        public Button(int top, int left) : base(top, left)
        {

        }
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a Button at {0}: {1} ", top, left);
        }
    }
}

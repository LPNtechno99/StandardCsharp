using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopTruuTuong_abstract_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Window[] windowArray = new Window[3];
            windowArray[0] = new ListBox(1, 2, "This is Listbox First");
            windowArray[1] = new ListBox(3, 4, "This is Button Second");
            windowArray[2] = new Button(4, 5, "This is a Button");
            for(int i=0;i<3;i++)
            {
                windowArray[i].DrawWindow();
            }
            Console.ReadLine();
        }
    }
    abstract public class Window
    {
        protected int top;
        protected int left;
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        abstract public void DrawWindow();
    }
    public class ListBox : Window
    {
        protected string listboxContent;
        public ListBox(int top, int left, string Content) : base(top, left)
        {
            listboxContent = Content;
        }
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a ListBox at: ({0}, {1}): {2}", top, left, listboxContent);
        }
    }
    public class Button:Window
    {
        protected string textButton;
        public Button(int top, int left, string ContentButton):base(top,left)
        {
            textButton = ContentButton;
        }
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a Button at: ({0}, {1}): {2}", top, left, textButton);
        }
    }
}

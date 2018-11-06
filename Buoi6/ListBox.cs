using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi6
{
    public class ListBox : Window
    {
        private string listBoxContents;

        public ListBox(int top, int left, string content) :base(top,left)
        {
            listBoxContents = content;
        }

        public override void DrawWindow()
        {
            Console.WriteLine("Bat Dau ListBox goi ham Draw cua WINDOW(HAM CHA) ");
            base.DrawWindow();
            Console.WriteLine("----Thuoc ve ListBox {0}", listBoxContents);
        }
    }
}
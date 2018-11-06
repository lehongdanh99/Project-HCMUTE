using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi6
{
    public class Window
    {
        private int top,left;

       
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        public virtual void DrawWindow()
        {
            Console.WriteLine("Ve window :-----> top {0} left {1} ", top, left);
        }
    }
} 


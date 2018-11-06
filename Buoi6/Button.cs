using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi6
{
    public class Button : Window
    {
        public Button(int top,int left) :base (top,left)
        {
            
        }
        //Đa Hình
        public override void DrawWindow()
        {
            Console.WriteLine("Ve Lai WINDOW: ");
            base.DrawWindow();
            Console.WriteLine("----Ket thuc ve lai WINDOW----");
        }
        public void DrawWindow(int a, int b)
        {
            Console.WriteLine("Day la ham DRAW cua rieng BUTTON voi 2 thong so {0} va {1}", a, b);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi6
{
    public class MainFunc
    {
        static void Main()
        {
            Window win = new Window(1, 2);
            ListBox b = new ListBox(3, 4,"viet lai ham listbox");
            Button c = new Button(5, 6);
            win.DrawWindow();
            b.DrawWindow();
            c.DrawWindow();

            //Mot Mang OBJECT
            Console.WriteLine();
            Window[] array = new Window[3];
            array[0] = new Window(1, 2);
            array[1] = new ListBox(3, 4, "Tuong tu Listbox tren");
            array[2] = new Button(5, 6);
            Console.WriteLine("In ra cac phan tu trong mang: ");
            for ( int i =0;i < 3; i++)
            {
                array[i].DrawWindow();
            }
            Console.WriteLine();
            c.DrawWindow(3, 5);
        }
    }
}
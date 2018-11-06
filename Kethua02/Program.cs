using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethua02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vi Du Property trong C#: ");
            Console.WriteLine("----------");
            //Tao doi tuong studen
            Student s = new Student();
            s.Code = "17110108";
            s.name = "Danh ";
            s.Age1 = 20;
            Console.WriteLine("Thong tin sinh vien {0}", s);
            //Bay gio tuoi tang them 1
            s.Age1 += 1;
            Console.WriteLine("Thong tin sinh vien +1 {0}", s);
            Console.ReadKey();
        }
    }
    class Student
    {
        private string code = "";
        private string Name = "";
        private int Age = 0;
        public string Code   
        {
           get { return code; }
            set { code = value; }
        }

        public string name
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public int Age1
        {
            get
            {
                return Age;
            }

            set
            {
                Age = value;
            }
        }

        public override string ToString()
        {
            return "MSSV = " + code + ",Ho Ten: " +Name  + ",Tuoi: " + Age;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua03
{
  

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ke thua OOP C#! ");
            Console.WriteLine("------------\n");
            // tao doi tuong hinh chu nhat
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.Chieu_Rong1 = 5; hcn.Chieu_Dai1 = 7;
            Console.WriteLine("Chieu rong {0},  chieu dai {1}",hcn.Chieu_Rong1,hcn.Chieu_Dai1 );
            Console.WriteLine("Dien tich hinh la: {0}", hcn.TinhDienTich());
        }
    }
    class Shape
    {
        private int Chieu_Dai;
        private int Chieu_Rong;

        public  int Chieu_Dai1
        {
            get
            {
                return Chieu_Dai;
            }

            set
            {
                Chieu_Dai = value;
            }
        }

        public  int Chieu_Rong1
        {
            get
            {
                return Chieu_Rong;
            }

            set
            {
                Chieu_Rong = value;
            }
        }
    }
    class HinhChuNhat : Shape
    {
        public int TinhDienTich()
        {
            return (Chieu_Dai1 * Chieu_Rong1);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh ke thua trong C#: ");
            Console.WriteLine("Khoi tao lop co so ");
            Console.WriteLine("------------------------\n");
            ChiPhiXayDung t = new ChiPhiXayDung(4.5, 7.5);
            t.hienthiThongTin();
            Console.ReadKey();
        }
    }
    class HinhChuNhat
    {
        protected double chieu_dai;
        protected double chieu_rong;
        
        public HinhChuNhat(double l, double w)
        {
            chieu_dai = l;
            chieu_rong = w;
        }
        public double TinhDienTich()
        {
            return chieu_dai * chieu_rong;
        }
        public void Display()
        {
            Console.WriteLine("Chieu dai: {0} ", chieu_dai);
            Console.WriteLine("Chieu rong: {0}", chieu_rong);
            Console.WriteLine("Dien tich: {0}", TinhDienTich());
        }
    }
    class ChiPhiXayDung : HinhChuNhat
    {
        public ChiPhiXayDung(double l, double w) :base(l,w)
            { }
        public double tinhChiphi()
        {
            double chi_phi;
            chi_phi = TinhDienTich() * 70;
            return chi_phi;
        }
        public void hienthiThongTin()
        {
            base.Display();
            Console.WriteLine("Chi phi: {0} ", tinhChiphi());
        }
    }
}

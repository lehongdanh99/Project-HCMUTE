using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace AnhVIet
{
    public partial class Form1 : Form 
    {
       
       
        NODE node , root= new NODE();
        Tree tree = new Tree();
        string T = "admin";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            String Line;
            StreamReader sr = new StreamReader("D:\\Tudien.txt");
            Line = sr.ReadLine();
            while (Line != null)
            {
                string[] words = Line.Split(':');       //Slpit tách chuổi thành 2 chuổi nhỏ bới dấu hai chấm
                node = tree.Insert(node, words[0], words[1]);
                Line = sr.ReadLine();
            }
            root = node;
            sr.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 add = new Form2();
            add.ShowDialog();
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            Tree a = new Tree();
            a.Del(ref root, "load");
            textBox1.Text = "";
            txtNghiaTu.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.GC.Collect();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if(txtTK.Text==T && txtMK.Text==T)
            {
                MessageBox.Show("Đăng nhập thành công");
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đã nhập sai thông tin đăng nhập","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                if (tree.Seacrch(root, textBox1.Text) != null)
                {
                    txtNghiaTu.Text = tree.Seacrch(root, textBox1.Text);
                }
            else
          
                MessageBox.Show("Không có từ này! Bạn có thể thêm từ ^^");
        }      
    }
}

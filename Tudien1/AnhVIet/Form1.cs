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
using System.Speech.Synthesis;
using System.Threading;

namespace AnhVIet
{
    public partial class Form1 : Form 
    {
       
       
        NODE node , root= new NODE();
        Tree tree = new Tree();
        string T = "admin";
        SpeechSynthesizer read;  //âm thanh
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(3500);
            
            InitializeComponent();
            t.Abort();
            


        }
        private void SplashScreen()
        {
            Application.Run(new Form4());
            Form4 fb1 = new Form4();
                fb1.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("G:\\Tudien.txt"))
            {
                MessageBox.Show("Error", "Không tìm thấy file nguồn");
                this.Close();
            }
            else
            {
                String Line;
                StreamReader sr = new StreamReader("G:\\Tudien.txt");
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

        }

        internal void DialogResult()
        {
            throw new NotImplementedException();
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
           if( MessageBox.Show("Bạn có muốn thoát khỏi chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel=true;
            }
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

        private void btnRead_Click(object sender, EventArgs e)
        {
            read = new SpeechSynthesizer();
            read.SpeakAsync(textBox1.Text);
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

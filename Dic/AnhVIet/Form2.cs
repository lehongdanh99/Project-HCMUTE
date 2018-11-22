using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnhVIet
{
    public partial class Form2 : Form
    {
        String Line;
        NODE node = null, root = new NODE();
        Tree tree = new Tree();
        public Form2()
        {
            InitializeComponent();
        }

        private void MeanBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.GC.Collect();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (MeanBox.Text == "" || WordBox.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ nghĩa và từ! ", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StreamReader sr = new StreamReader("D:\\Tudien.txt");
                Line = sr.ReadLine();
                while (Line != null)
                {
                    string[] words = Line.Split(':');       //Slpit tách chuổi thành 2 chuổi nhỏ bới dấu hai chấm
                                                            //node = tree.Insert(ref node, words[0], words[1]);
                    tree.Insert(root, words[0], words[1]);
                    Line = sr.ReadLine();
                }
                    root = node;
                    sr.Close();
                
                string fword = WordBox.Text;
                if (tree.Seacrch(root, fword) != null)
                {
                    MessageBox.Show("Từ đã có trong từ điển! ");
                }                                
                else
                {
                        //Pass the filepath and filename to the StreamWriter Constructor
                        StreamWriter sw = new StreamWriter("D:\\Tudien.txt", true);

                        //Write a line of text
                        sw.WriteLine(WordBox.Text + ":" + MeanBox.Text);
                        sw.Close();
                        MessageBox.Show("Them Thanh Cong! ");
                }
                
            }
        }
    }
}


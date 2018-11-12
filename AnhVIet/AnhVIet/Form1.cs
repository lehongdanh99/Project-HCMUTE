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
        List<NODE> s = new List<NODE>();
        String Line;
        NODE node = null , root= new NODE();
        Tree tree = new Tree();

        public Form1()
        {
            InitializeComponent();
           
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 add = new Form2();
               
            if (add.ShowDialog() == DialogResult.OK) MessageBox.Show("thêm thành công");
            this.Close();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string FWord = textBox1.Text;
            if (tree.Seacrch(root, FWord) != null)
                MessageBox.Show(tree.Seacrch(root, FWord));
        }

       
        
    }

    
   
    
}

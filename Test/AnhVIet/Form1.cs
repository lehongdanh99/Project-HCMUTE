﻿using System;
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
            Form2 add = new Form2();
            add.ShowDialog();
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.GC.Collect();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string FWord = textBox1.Text;
                if (tree.Seacrch(root, FWord) != null)
                {
                    txtNghiaTu.Text = tree.Seacrch(root, FWord);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Không có từ này! Bạn có thể thêm từ ^^");

            }
        }      
    }
}

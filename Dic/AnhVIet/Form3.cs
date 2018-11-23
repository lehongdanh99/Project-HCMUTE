﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace AnhVIet
{
    public partial class Form3 : Form
    {
        NODE node, root = new NODE();
        Tree tree = new Tree();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int count = 0;     // Varialble used to perform count of columns before moving to next row in table.
            string line = "";  // Variable used to store data from file.txt
            StreamReader sr = new StreamReader("D:\\Tudien.txt"); // Reads the data from the file.txt file
            while (!sr.EndOfStream)  // Allows for data in Text file to be separated by comma delimiter 
            {
                line += sr.ReadLine() + ":";
                count++;

                if (count >= 2) // Adds data to correct rows in table by counting the columns        
                {
                    string[] parts = line.Split(':').ToArray();
                    DataGV.Rows.Add(parts[0], parts[1]);
                    node = tree.Insert(node, parts[0], parts[1]);
                    count = 0;
                    line = "";
                }
            }
            root = node;
            sr.Close();
            int totalWidth = 0;

            //Auto Resize the columns to fit the data 
            foreach (DataGridViewColumn column in DataGV.Columns)
            {
                DataGV.Columns[column.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                int widthCol = DataGV.Columns[column.Index].Width;
                DataGV.Columns[column.Index].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                DataGV.Columns[column.Index].Width = widthCol;
                totalWidth = totalWidth + widthCol;
            }
            //the selector on the left of the DataGridView is about 45 in width 
            DataGV.Width = totalWidth + 120;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGV.Update();
            DataGV.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tree.Seacrch(root, DelBox.Text.ToString()) == null)
            {
                MessageBox.Show("Khong co tu nay trong tu dien! ");
            }
            else
            {
                string Filepath = @"D:\Tudien.txt";
                System.IO.File.WriteAllText(Filepath, "");
                tree.Del(ref root, DelBox.Text);
                tree.Traverse(root);
                MessageBox.Show("Xoa Thanh Cong! ");
            }
        }
    }

}


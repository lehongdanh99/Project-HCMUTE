using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Node> s = new List<Node>();
        String line;
        Node node = null, root = new Node();
        Tree tree = new Tree();
        public Form1()
        {
            InitializeComponent();              
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("G:\\CauTrucGT\\TDCayNhiPhan\\Tudienanhvietxaydung.txt");
                //Read the first line of text
                line = sr.ReadLine();                
                //Continue to read until you reach end of file
                while (line != null)
                {
                    string[] words = line.Split(':');
                    node = tree.insert(node, words[0],words[1]);
                    //write the lie to console window                    
                    //Read the next line                   
                    line = sr.ReadLine();
                }
                root = node;
                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:" + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnS_Click(object sender, EventArgs e)
        {            
            string sString = textBox1.Text;            
            if (tree.traverse(root, sString) != null) MessageBox.Show(tree.traverse(root, sString));                                      
        }
        private void btn(object sender, EventArgs e)
        {
            addNode f = new addNode();
            if (f.ShowDialog() == DialogResult.OK) MessageBox.Show("thêm thành công");
        }
    }
}

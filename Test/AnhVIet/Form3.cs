using System;
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
        public Form3()
        {
            InitializeComponent();
        }

        private void Tu_Click(object sender, EventArgs e)
        {

        }

        private void ShowListView()
        {
            ListViewItem lv = new ListViewItem("abc");
            lv.SubItems.Add("efg");
            listView1.Items.Add(lv);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //NODE tree = new NODE();
            //Traverse
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            String Line;
            StreamReader sr = new StreamReader("D:\\Tudien.txt");
            Line = sr.ReadLine();
            while (Line != null)
            {
                string[] words = Line.Split(':');
                ShowListView();
            }
        }
    }
}

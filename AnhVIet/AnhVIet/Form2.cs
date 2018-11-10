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
        public Form2()
        {
            InitializeComponent();
        }

       
        private void btn_Click(object sender, EventArgs e)
        {

            if (this.DialogResult == DialogResult.OK)
            {
                try
                {

                    //Pass the filepath and filename to the StreamWriter Constructor
                    StreamWriter sw = new StreamWriter("G:\\Tudienanhvietxaydung.txt", true);

                    //Write a line of text
                    sw.WriteLine(WordBox.Text + ":" + MeanBox.Text);

                    //Write a second line of text                

                    //Close the file
                    sw.Close();
                }
                catch(Exception u)
                {
                    Console.WriteLine(" biet le la:" + u.Message);
                }
                finally
                {
                    Console.WriteLine("Da xu ly biet le");
                }
            }
        }

     
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.ApplicationBlocks.Data;
//khai báo mình sẽ sử dụng thư viện SQLHelper
namespace BANGDANGNHAP
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void btTraTu_Click(object sender, EventArgs e)
        {
            // khi chỉ cần tra từ thì hiện thẳng chương trình
            frmMain frmMainn = new frmMain();
            frmMainn.ShowDialog();
            this.Hide();
        }

        private void btQL_Click(object sender, EventArgs e)
        {
            // khi cần xử lý các lệnh thêm từ xóa,  thì cho hiện form đăng nhập để quản lý từ
            groupBox1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //xử lý nút đăng nhập
            //khi đăng nhập thì nó sẽ kiểm tra với database xem có tồn tại user name và password này không, nếu có
            //nếu có thì mở form Quản lý lên
            try
            {
                //khai báo 2 biến chuổi sẽ chứa giá trị được nhập từ TextBox
                string user = txtUser.Text.Trim(); //Trim để xóa khoảng trống  ở đầu  và cuối chuổi nếu user có nhập nhầm
                string pass = txtPass.Text.Trim();

                //sẽ tạo 1 bảng trắng chứa Table mình sẽ get về (nếu có)
                //cấu trúc câu lệnh SQLHelper (chuổi ết nối, tên proceduc, biến truyền vào nếu có
                DataTable dt = SqlHelper.ExecuteDataset(SQLstring.strcnn, "Login_Select", user ,pass).Tables[0];
                //sử lý khi người dùng nhập đúng
                if(dt.Rows.Count >0)  //số row phải lớn hơn số 0 nếu trùng user và pass
                {
                    frmQuanLyTu frm = new frmQuanLyTu();
                    frm.Show(); // cho hiện cái form quản lú từ lên
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     
    }
}

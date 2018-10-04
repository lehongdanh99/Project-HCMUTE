using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;

namespace BANGDANGNHAP
{
    public partial class frmQuanLyTu : Form
    {
        public frmQuanLyTu()
        {
            InitializeComponent();
            loaddata();   //cho khi chạy Form thì nó tự load data lun

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                //khai báo các biến sẽ truyền vào
                string id = txtID.Text.Trim();
                string eng = txtEnglish.Text.Trim();
                string shorvn = txtShorVN.Text.Trim();
                string dich = txtdich.Text.Trim();
                //Truyền dữ liệu lên SQL
                SqlHelper.ExecuteNonQuery(SQLstring.strcnn, "TuDien_Them", id, eng, shorvn, dich);
                MessageBox.Show("Thêm Thành Công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

        }

        private void loaddata()
        {
            gridItemData.DataSource = SqlHelper.ExecuteDataset(SQLstring.strcnn, "TuDien_Select").Tables[0];
        }
        private void btlammoi_Click(object sender, EventArgs e)
        {
            loaddata();
        }

      
        
    }
}

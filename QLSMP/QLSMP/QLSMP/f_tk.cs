using QLSMP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSMP
{
    public partial class f_tk : Form
    {
        public f_tk()
        {
            InitializeComponent();
            loaddata();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void resert()
        {
            txt_tentk.Clear();
            txt_matkhau.Clear();
        }
       void loaddata()
        {
            string query = "SELECT*FROM DANGNHAP";//khi có nhiều parameter phải cách ra dấy , (dùng để add nhiều parameter)
            dgv_dangnhap.DataSource = DataProvider.Instance.ExecuteQuery(query);
            //dgv_dangnhap.DataSource = provider.ExecuteQuery(query, new object[] ("parameter"); thêm nhiều parameter
        }

        private void dgv_dangnhap_Click(object sender, EventArgs e)
        {
            txt_tentk.Text = dgv_dangnhap.CurrentRow.Cells["USERNAME"].Value.ToString();
            txt_matkhau.Text = dgv_dangnhap.CurrentRow.Cells["PASSWORD"].Value.ToString();
            if (dgv_dangnhap.CurrentRow.Cells["QUYEN"].Value.ToString() == "ADMIN")
            {
                chkquyen.Checked = true;
            }
            else
                chkquyen.Checked = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string q;
            if (chkquyen.Checked == true)
            {
                q = "ADMIN";
            }
            else
                q = "USER";
            if (txt_tentk.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên tài khoản!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tentk.Focus();
                return;
            }
            if (txt_matkhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_matkhau.Focus();
                return;
            }
            string username = txt_tentk.Text;
            string matkhau = txt_matkhau.Text;
            string quyen = q;
            TaiKhoanDAO.Instance.themTK(username, matkhau, quyen);
            resert();
            loaddata();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            resert();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string q;
            if (txt_tentk.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tentk.Focus();
                return;
            }
            if (chkquyen.Checked == true)
                q = "ADMIN";
            else
                q = "USER";
            string username = txt_tentk.Text;
            string matkhau = txt_matkhau.Text;
            string quyen = q;
            TaiKhoanDAO.Instance.suaTK(username, matkhau, quyen );
            MessageBox.Show("Sửa Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resert();
            loaddata();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_tentk.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tentk.Focus();
                return;
            }
            string username = txt_tentk.Text;
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TaiKhoanDAO.Instance.xoaTK(username);
                resert();
                loaddata();
            }
        }
    }
}

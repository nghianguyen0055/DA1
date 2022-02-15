using QLSMP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSMP
{
    public partial class f_nhanvien : Form
    {
        public f_nhanvien()
        {
            InitializeComponent();
            loaddata();
        }
        void loaddata()
        {
            string query = "select*from nhanvien";
            dgv_nhanvien.DataSource = DataProvider.Instance.ExecuteQuery(query);
            txt_tennv.Focus();
            reset();
        }
        void reset()
        {
            string query = "NHANVIEN_TUTANGID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            txt_manv.Text = dt.Rows[0][0].ToString();
            txt_tennv.Clear();
            txt_sdt.Clear();
            txt_diachi.Clear();
            txttimkiem.Clear();
        }
        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            reset();
            loaddata();
        }

        private void dgv_nhanvien_Click(object sender, EventArgs e)
        {
            if (dgv_nhanvien.CurrentRow.Cells["GIOITINH"].Value.ToString() == "NAM" || dgv_nhanvien.CurrentRow.Cells["GIOITINH"].Value.ToString() == "Nam")
                chkgioitinh.Checked = true;
            else
                chkgioitinh.Checked = false;
            txt_manv.Text = dgv_nhanvien.CurrentRow.Cells["manv"].Value.ToString();
            txt_diachi.Text = dgv_nhanvien.CurrentRow.Cells["dchi"].Value.ToString();
            txt_tennv.Text = dgv_nhanvien.CurrentRow.Cells["tennv"].Value.ToString();
            txt_sdt.Text = dgv_nhanvien.CurrentRow.Cells["sdt"].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string gt;
            if (chkgioitinh.Checked == true)
            {
                gt = "Nam";
            }
            else
                gt = "Nữ";
            if (txt_tennv.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tennv.Focus();
                return;
            }
            if (txt_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return;
            }
            if (txt_sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdt.Focus();
                return;
            }
            string manv = txt_manv.Text;
            string tennv = txt_tennv.Text;
            string gioitinh = gt;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            nhanvienDAO.Instance.themNV(manv, tennv, gioitinh, diachi, sdt);
            reset();
            loaddata();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string gt;
            if (txt_tennv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tennv.Focus();
                return;
            }
            if (chkgioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            string tennv = txt_tennv.Text;
            string manv = txt_manv.Text;
            string gioitinh = gt;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            nhanvienDAO.Instance.suaNV(manv, tennv, gioitinh, diachi, sdt);
            MessageBox.Show("Sửa Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
            loaddata();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_tennv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tennv.Focus();
                return;
            }
            string manv = txt_manv.Text;
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                nhanvienDAO.Instance.xoaNV(manv);
                reset();
                loaddata();
            }
            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = "select * from nhanvien where manv like '%" + txttimkiem.Text.Trim() + "'";
            dgv_nhanvien.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }
    }
}

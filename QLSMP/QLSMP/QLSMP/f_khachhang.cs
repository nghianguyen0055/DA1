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
    public partial class f_khachhang : Form
    {
        public f_khachhang()
        {
            InitializeComponent();
            loaddata();
        }
        void loaddata()
        {
            string query = "select* from khachhang";
            dgv_khachhang.DataSource = DataProvider.Instance.ExecuteQuery(query);
            txt_tenkh.Focus();
            resetvalues();
            //ktra();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_khachhang_Click(object sender, EventArgs e)
        {
            if (dgv_khachhang.CurrentRow.Cells["GIOITINH"].Value.ToString() == "NAM" || dgv_khachhang.CurrentRow.Cells["GIOITINH"].Value.ToString() == "Nam")
                chkgioitinh.Checked = true;
            else
                chkgioitinh.Checked = false;
            txt_makh.Text = dgv_khachhang.CurrentRow.Cells["MAKH"].Value.ToString();
            txt_tenkh.Text = dgv_khachhang.CurrentRow.Cells["TENKH"].Value.ToString();
            txt_diachi.Text = dgv_khachhang.CurrentRow.Cells["DIACHI"].Value.ToString();
            txt_sdt.Text = dgv_khachhang.CurrentRow.Cells["SDT"].Value.ToString();
        }

        void resetvalues()
        {
            string qrr = "exec SP_khachhang_TUTANGID ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(qrr);
            txt_makh.Text = dt.Rows[0][0].ToString();
            txt_tenkh.Clear();
            txt_diachi.Clear();
            txt_sdt.Clear();
            txttimkiem.Clear();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string gt;
            if (txt_tenkh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenkh.Focus();
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
            if (chkgioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";

            string tenkh = txt_tenkh.Text;
            string makh = txt_makh.Text;
            string gioitinh = gt;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            KhachHangDAO.Instance.insertKH(makh, tenkh, gioitinh, diachi, sdt);
            //MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetvalues();
            loaddata();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            resetvalues();
            loaddata();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string gt;
            if (txt_tenkh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenkh.Focus();
                return;
            }
            if (chkgioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            string tenkh = txt_tenkh.Text;
            string makh = txt_makh.Text;
            string gioitinh = gt;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            KhachHangDAO.Instance.editKH(makh, tenkh, gioitinh, diachi, sdt);
            MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetvalues();
            loaddata();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_tenkh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenkh.Focus();
                return;
            }
            string makh = txt_makh.Text;
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KhachHangDAO.Instance.deleteKH(makh);
                resetvalues();
                loaddata();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = "select * from khachhang where makh like'%"+txttimkiem.Text.Trim()+"%'";
            dgv_khachhang.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }
    }
}

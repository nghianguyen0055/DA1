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
    public partial class f_ncc : Form
    {
        public f_ncc()
        {
            InitializeComponent();
            loaddata();
        }
        void loaddata()
        {
            string query = "select*from nhacungcap";
            dgv_ncc.DataSource = DataProvider.Instance.ExecuteQuery(query);
            reset();
            txt_tenncc.Focus();
        }
        void reset()
        {
            string qr = "NHACUNGCAP_TUTANGID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(qr);
            txt_mancc.Text = dt.Rows[0][0].ToString();
            txt_tenncc.Text = "";
            txt_diachincc.Text = "";
            txt_sdtncc.Text = "";
            txttimkiem.Clear();
        }

        

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_moi_Click(object sender, EventArgs e)
        {
            reset();
            loaddata();
            txt_tenncc.Focus();
        }
        

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_tenncc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên Nhà Cung Cấp!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenncc.Focus();
                return;
            }
            if (txt_diachincc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ nhà cung cấp!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachincc.Focus();
                return;
            }
            if (txt_sdtncc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại nhà cung cấp!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdtncc.Focus();
                return;
            }
            string mancc = txt_mancc.Text;
            string tenncc = txt_tenncc.Text;
            string diachi = txt_diachincc.Text;
            string sdt = txt_sdtncc.Text;
            NccDAO.Instance.themNCC(mancc, tenncc, diachi, sdt);
           // MessageBox.Show("Thêm thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
            loaddata();
        }

        private void dgv_ncc_Click(object sender, EventArgs e)
        {
            txt_mancc.Text = dgv_ncc.CurrentRow.Cells["mancc"].Value.ToString();
            txt_tenncc.Text = dgv_ncc.CurrentRow.Cells["tenncc"].Value.ToString();
            txt_diachincc.Text = dgv_ncc.CurrentRow.Cells["dchi"].Value.ToString();
            txt_sdtncc.Text = dgv_ncc.CurrentRow.Cells["sdt"].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_tenncc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenncc.Focus();
                return;
            }
            string mancc = txt_mancc.Text;
            string tenncc = txt_tenncc.Text;
            string diachi = txt_diachincc.Text;
            string sdt = txt_sdtncc.Text;
            NccDAO.Instance.suaNCC(mancc, tenncc, diachi, sdt);
            MessageBox.Show("Sửa thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
            loaddata();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_tenncc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenncc.Focus();
                return;
            }
            string mancc = txt_mancc.Text;
            NccDAO.Instance.xoaNCC(mancc);
            MessageBox.Show("Xóa thành công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
            loaddata();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = "select *from nhacungcap where mancc like '%" + txttimkiem.Text.Trim() + "%'";
            dgv_ncc.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void txt_sdtncc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }
    }
}

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
    public partial class f_loai : Form
    {
        public f_loai()
        {
            InitializeComponent();
            loaddata();
            //ktra();
        }
        void loaddata()
        {
            string query = "select*from loai";
            dgv_loai.DataSource = DataProvider.Instance.ExecuteQuery(query);
            reset();
            txt_tenloai.Focus();
        }
        void reset()
        {
            string qr = "exec SP_LOAI_TUTANGID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(qr);
            txt_maloai.Text = dt.Rows[0][0].ToString();
            txt_tenloai.Text = "";
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
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_tenloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tenloai.Focus();
                return;
            }
            string maloai = txt_maloai.Text;
            string tenloai = txt_tenloai.Text;
            LoaiDAO.Instance.insertloai(maloai, tenloai);
            //MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
            loaddata();
        }

        private void dgv_loai_Click(object sender, EventArgs e)
        {
            txt_maloai.Text = dgv_loai.CurrentRow.Cells["maloai"].Value.ToString();
            txt_tenloai.Text = dgv_loai.CurrentRow.Cells["tenloai"].Value.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_tenloai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenloai.Focus();
                return;
            }
            string maloai = txt_maloai.Text;
            string tenloai = txt_tenloai.Text;
            LoaiDAO.Instance.editLoai(maloai, tenloai);
            MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
            loaddata();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_tenloai.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tenloai.Focus();
                return;
            }
            string maloai = txt_maloai.Text;
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoaiDAO.Instance.deleteLoai(maloai);
                reset();
                loaddata();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = "select * from loai where maloai like '%" + txttimkiem.Text.Trim() + "%'";
            dgv_loai.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}


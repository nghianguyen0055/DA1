using QLSMP.DAO;
using QLSMP.DTO;
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
    public partial class f_hdn : Form
    {
        public f_hdn()
        {
            InitializeComponent();
            loaddata();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loaddata()
        {
            string query = "select*from HOADONNHAP";
            dgv_hdn.DataSource = DataProvider.Instance.ExecuteQuery(query);
            loadmanv();
            loadmancc();
            loadsp();
            reset();
        }
        void reset()
        {
            string query = "exec HDN_TUTANG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            txt_mahdn.Text = dt.Rows[0][0].ToString();
            cbbmanv.Text = "";
            cbbmancc.Text = "";
            cbbmasp.Text = "";
            txt_gia.Text = "0";
            txttimkiem.Clear();
            txt_diachi.Clear();
            txt_sdt.Clear();
            dtpk_hdn.Value = DateTime.Now;
            txttongtien.Text = "0";
            nmrsl.Value = 0;
        }
        void loadmanv()
        {
            List<NHANVIEN> listnv = nhanvienDAO.Instance.laynv();
            cbbmanv.DataSource = listnv;
            cbbmanv.DisplayMember = "tennv";
            cbbmanv.ValueMember = "manv";
        }
        void loadmancc()
        {
            List<NCC> listncc = NccDAO.Instance.layncc();
            cbbmancc.DataSource = listncc;
            cbbmancc.DisplayMember = "tenncc";
            cbbmancc.ValueMember = "mancc";
        }
        void loadsp()
        {
            List<sanpham> listsp = sanphamDAO.Instance.laysp();
            cbbmasp.DataSource = listsp;
            cbbmasp.DisplayMember = "tensp";
            cbbmasp.ValueMember = "masp";
        }

        private void btn_moi_Click(object sender, EventArgs e)
        {
            reset();
            loaddata();
        }

        private void dgv_hdn_Click(object sender, EventArgs e)
        {
            txt_mahdn.Text = dgv_hdn.CurrentRow.Cells["mahdn"].Value.ToString();
            cbbmancc.Text = dgv_hdn.CurrentRow.Cells["mancc"].Value.ToString();
            cbbmanv.Text = dgv_hdn.CurrentRow.Cells["manv"].Value.ToString();
            cbbmasp.Text = dgv_hdn.CurrentRow.Cells["masp"].Value.ToString();
            txttongtien.Text = dgv_hdn.CurrentRow.Cells["tongtien"].Value.ToString();
            txt_diachi.Text = dgv_hdn.CurrentRow.Cells["dchi"].Value.ToString();
            txt_gia.Text = dgv_hdn.CurrentRow.Cells["gia"].Value.ToString();
            dtpk_hdn.Text = dgv_hdn.CurrentRow.Cells["ngaynhap"].Value.ToString();
            nmrsl.Text = dgv_hdn.CurrentRow.Cells["soluong"].Value.ToString();
            txt_sdt.Text = dgv_hdn.CurrentRow.Cells["sdt"].Value.ToString();
        }

        private void nmrsl_ValueChanged(object sender, EventArgs e)
        {
            int sl = (int)nmrsl.Value;
            if (sl > 0)
            {
                int sll = (int)nmrsl.Value;
                int gia = Convert.ToInt32(txt_gia.Text);
                int tong = sll * gia;
                txttongtien.Text = tong.ToString();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_diachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return;
            }
            if (txt_gia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_gia.Focus();
                return;
            }
            if (txt_sdt.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdt.Focus();
                return;
            }
            string mahdn = txt_mahdn.Text;
            string manv = cbbmanv.SelectedValue.ToString();
            string masp = cbbmasp.SelectedValue.ToString();
            string mancc = cbbmancc.SelectedValue.ToString();
            int soluong = (int)nmrsl.Value;
            DateTime ngaynhap = dtpk_hdn.Value;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            int gia = Convert.ToInt32(txt_gia.Text);
            int tongtien = Convert.ToInt32(txttongtien.Text);
            hdnDAO.Instance.themHDN(mahdn, manv, masp, mancc, soluong, ngaynhap, diachi, sdt, gia, tongtien);
            reset();
            loaddata();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_diachi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diachi.Focus();
                return;
            }
            string mahdn = txt_mahdn.Text;
            string manv = cbbmanv.SelectedValue.ToString();
            string masp = cbbmasp.SelectedValue.ToString();
            string mancc = cbbmancc.SelectedValue.ToString();
            int soluong = (int)nmrsl.Value;
            DateTime ngaynhap = dtpk_hdn.Value;
            string diachi = txt_diachi.Text;
            string sdt = txt_sdt.Text;
            int gia = Convert.ToInt32(txt_gia.Text);
            int tongtien = Convert.ToInt32(txttongtien.Text);
            hdnDAO.Instance.suaHDN(mahdn, manv, masp, mancc, soluong, ngaynhap, diachi, sdt, gia, tongtien);
            MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
            loaddata();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_diachi.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_diachi.Focus();
                return;
            }
            string mahdn = txt_mahdn.Text;
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                hdnDAO.Instance.xoaHDN(mahdn);
                reset();
                loaddata();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = "select*from hoadonnhap where mahdn like '%" + txttimkiem.Text.Trim() + "%'";
            dgv_hdn.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }
    }
}

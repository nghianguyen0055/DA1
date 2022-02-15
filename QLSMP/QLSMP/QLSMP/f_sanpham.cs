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
    public partial class f_sanpham : Form
    {
        public f_sanpham()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            string query = "select*from sanpham";
            dgv_sanpham.DataSource = DataProvider.Instance.ExecuteQuery(query);
            loadloai();
            loadmaNCC();
            reset();
        }

        void reset()
        {
            string query = "SP_SANPHAM_TUTANGIDDD";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            txt_masp.Text = dt.Rows[0][0].ToString();
            txt_tensp.Clear();
            txt_soluong.Clear();
            txt_gia.Clear();
            cbbNCC.Text = "";
            cbbmaloai.Text = "";
            txttimkiem.Clear();
        }

        void loadmaNCC()
        {
            List<NCC> listncc = NccDAO.Instance.layncc();
            cbbNCC.DataSource = listncc;
            cbbNCC.DisplayMember = "tenncc";
            cbbNCC.ValueMember = "mancc";
        }
        void loadloai()
        {
            List<LOAI> listloai = LoaiDAO.Instance.layloai();
            cbbmaloai.DataSource = listloai;
            cbbmaloai.DisplayMember = "tenloai";
            cbbmaloai.ValueMember = "maloai";
        }
        private void btn_dongsp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            reset();
            load();
        }

        private void btn_themsp_Click(object sender, EventArgs e)
        {
          
            if (txt_tensp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_tensp.Focus();
                return;
            }
            if (txt_gia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_gia.Focus();
                return;
            }
            if (txt_soluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_soluong.Focus();
                return;
            }
            string masp = txt_masp.Text;
            string tensp = txt_tensp.Text;
            string ml = cbbmaloai.SelectedValue.ToString();
            string mancc = cbbNCC.SelectedValue.ToString();
            int soluong = Convert.ToInt32(txt_soluong.Text);
            float gia = (float)Convert.ToDouble(txt_gia.Text);
            sanphamDAO.Instance.themSP(masp, tensp, mancc, ml, soluong, gia);
            reset();
            load();
        }

        private void dgv_sanpham_Click(object sender, EventArgs e)
        {
            txt_masp.Text = dgv_sanpham.CurrentRow.Cells["masp"].Value.ToString();
            cbbmaloai.Text = dgv_sanpham.CurrentRow.Cells["maloai"].Value.ToString();
            cbbNCC.Text = dgv_sanpham.CurrentRow.Cells["mancc"].Value.ToString();
            txt_gia.Text = dgv_sanpham.CurrentRow.Cells["gia"].Value.ToString();
            txt_soluong.Text = dgv_sanpham.CurrentRow.Cells["soluong"].Value.ToString();
            txt_tensp.Text = dgv_sanpham.CurrentRow.Cells["tensp"].Value.ToString();
        }

        private void btn_suasp_Click(object sender, EventArgs e)
        {
            if (txt_tensp.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tensp.Focus();
                return;
            }
            string masp = txt_masp.Text;
            string tensp = txt_tensp.Text;
            string ml = cbbmaloai.SelectedValue.ToString();
            string mancc = cbbNCC.SelectedValue.ToString();
            int soluong = Convert.ToInt32(txt_soluong.Text);
            float gia = (float)Convert.ToDouble(txt_gia.Text);
            sanphamDAO.Instance.suaSP(masp, tensp, mancc, ml, soluong, gia);
            MessageBox.Show("Sửa Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
            load();
        }

        private void btn_xoasp_Click(object sender, EventArgs e)
        {
            if (txt_tensp.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tensp.Focus();
                return;
            }
            string masp = txt_masp.Text;
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sanphamDAO.Instance.xoaSP(masp);
                reset();
                load();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = "select * from sanpham where masp like '%" + txttimkiem.Text.Trim() + "%'";
            dgv_sanpham.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}

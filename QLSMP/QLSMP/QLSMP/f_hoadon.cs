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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QLSMP
{
    public partial class f_hoadon : Form
    {

        public f_hoadon()
        {
            InitializeComponent();
            load();
            loadcthd();
        }
        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       void load()
        {
            string query = "select*from hoadon";
            dgv_hoadon.DataSource = DataProvider.Instance.ExecuteQuery(query);
           // string queryy = "select* from cthd";
           // dgv_cthd.DataSource = DataProvider.Instance.ExecuteQuery(queryy);
            cbbmanv.Focus();
            loadmanv();
            loadkh();
            loadhoadon();
            loadsanpham();
            tinhtien();
            ktra();
            reset();
        }
        void loadcthd()
        {
            string queryy = "select* from cthd where mahd = '"+cbbmahct.SelectedValue.ToString()+"'";
            dgv_cthd.DataSource = DataProvider.Instance.ExecuteQuery(queryy);
        }
        void reset()
        {
            string query = "exec HOADON_TUTANGID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            txt_mahd.Text = dt.Rows[0][0].ToString();
            string qr = "exec HOADONCT_TUTANGID";
            DataTable dtt = DataProvider.Instance.ExecuteQuery(qr);
            txtmacthd.Text = dtt.Rows[0][0].ToString();
            cbbdongia.Text = "0";
            nmrsoluong.Value = 0;
            txtthanhtien.Text="0";
            nmrkhuyemmai.Value = 0;
            cbbmahct.Text = "";
            cbbmakh.Text = "";
            cbbmanv.Text = "";
            dtpk_hd.Value = DateTime.Now;
            txttongtien.Text = "0";
            txttimkiem.Clear();
        }
        void loadmanv()
        {
            List<NHANVIEN> listnv = nhanvienDAO.Instance.laynv();
            cbbmanv.DataSource = listnv;
            cbbmanv.DisplayMember = "tennv";
            cbbmanv.ValueMember = "manv";
        }
        void loadkh()
        {
            List<khachhang> listkh = KhachHangDAO.Instance.laykh();
            cbbmakh.DataSource = listkh;
            cbbmakh.DisplayMember = "tenkh";
            cbbmakh.ValueMember = "makh";
        }
        void loadhoadon()
        {
            List<hoadon> listhd = hoadonDAO.Instance.layhd();
            cbbmahct.DataSource = listhd;
            cbbmahct.DisplayMember = "mahd";
            cbbmahct.ValueMember = "mahd";
        }
        void loadsanpham()
        {
            List<sanpham> listspp = sanphamDAO.Instance.laysp();
            cbbmasp.DataSource = listspp;
            cbbmasp.DisplayMember = "tensp";
            cbbmasp.ValueMember = "masp";
        }
        void loaddongiaMASP(int gia)
        {
            List<sanpham> listsp = sanphamDAO.Instance.layspquaMASP(gia);
            cbbdongia.DataSource = listsp;
            cbbdongia.DisplayMember = "gia";
            cbbdongia.ValueMember = "gia";
        }
        private void dgv_hoadon_Click(object sender, EventArgs e)
        {
            if (dgv_hoadon.CurrentRow.Cells["trangthai"].Value.ToString() == "Đã Thanh Toán")
                chkTT.Checked = true;
            else
                chkTT.Checked = false;
            txt_mahd.Text = dgv_hoadon.CurrentRow.Cells["mahd"].Value.ToString();
            cbbmakh.Text = dgv_hoadon.CurrentRow.Cells["makh"].Value.ToString();
            cbbmanv.Text = dgv_hoadon.CurrentRow.Cells["manv"].Value.ToString();
            dtpk_hd.Text = dgv_hoadon.CurrentRow.Cells["ngayban"].Value.ToString();
            txttongtien.Text = dgv_hoadon.CurrentRow.Cells["tongtien"].Value.ToString();
            nmrkhuyemmai.Text = dgv_hoadon.CurrentRow.Cells["giamgia"].Value.ToString();
            string query = "select*from cthd where mahd='"+txt_mahd.Text+"'";
            dgv_cthd.DataSource = DataProvider.Instance.ExecuteQuery(query);
            ktra();
            tinhtien();
            cbbmahct.Text = txt_mahd.Text;
            btnthemhd.Enabled = false;

        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            btnthemhd.Enabled = true;
            reset();
            load();
        }
        private void cbbmasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            int gia = 0;
             System.Windows.Forms.ComboBox cb = sender as System.Windows.Forms.ComboBox;
             if (cb.SelectedItem == null)
                 return;
             sanpham  selected = cb.SelectedItem as sanpham;
             gia = selected.Gia;
             loaddongiaMASP(gia);
        }

        void tinhtien()
        {
            int n = dgv_cthd.Rows.Count;
            double tongcong = 0;
            double tong = 0;
            int giamgia = (int)nmrkhuyemmai.Value;
            if (n > 0)
           {
                tong = 0;
                for (int i = 0; i < n-1; i++)
                {
                    int gt = (int)dgv_cthd.Rows[i].Cells[5].Value;
                    tong +=gt ;
                }
                tongcong = tong - (tong / 100) * giamgia;
                txttongtien.Text = tongcong.ToString();
            }
        }
        void ktra()
        {
            if (chkTT.Checked == true)
            {
                btnthanhtoan.Enabled = false;
                btn_them.Enabled = false;
                btn_sua.Enabled = false;
                btn_xoa.Enabled = false;
                btnsuahd.Enabled = false;
                btn_in.Enabled = true;
            }
            else
            {
                btnthanhtoan.Enabled = true;
                btn_them.Enabled = true;
                btn_sua.Enabled = true;
                btn_xoa.Enabled = true;
                btnsuahd.Enabled = true;
                btn_in.Enabled = false;
            }
        }
        private void btnthemhd_Click(object sender, EventArgs e)
        {
            
        }
        private void nmrsoluong_ValueChanged(object sender, EventArgs e)
        {
            int sll = Convert.ToInt32(nmrsoluong.Value);
            if (sll > 0)
            {
                int sl = (int)(nmrsoluong.Value);
                int dongia = (int)cbbdongia.SelectedValue;
                int tong = sl * dongia;
                txtthanhtien.Text = tong.ToString();
            }
        }

        private void btnthemhd_Click_1(object sender, EventArgs e)
        {
            string tt;
            if (chkTT.Checked == true)
            {
                tt = "Đã Thanh Toán";
            }
            else
            {
                tt = "Chưa Thanh Toán";
            }
            string mahd = txt_mahd.Text;
            string manv = cbbmanv.SelectedValue.ToString();
            string makh = cbbmakh.SelectedValue.ToString();
            int giamgia = (int)nmrkhuyemmai.Value;
            DateTime ngayban = dtpk_hd.Value;
            string trangthai = tt;
            int tongtien = Convert.ToInt32(txttongtien.Text);
            hoadonDAO.Instance.themHD(mahd, manv, makh, giamgia, ngayban, tongtien, trangthai);
            reset();
            load();
        }

        private void btnsuahd_Click(object sender, EventArgs e)
        {
            string tt;
            if (chkTT.Checked == true)
            {
                tt = "Đã Thanh Toán";
            }
            else
            {
                tt = "Chưa Thanh Toán";
            }
            if (cbbmakh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbmakh.Focus();
                return;
            }
            string mahd = txt_mahd.Text;
            string manv = cbbmanv.SelectedValue.ToString();
            string makh = cbbmakh.SelectedValue.ToString();
            int giamgia = (int)nmrkhuyemmai.Value;
            DateTime ngayban = dtpk_hd.Value;
            string trangthai = tt;
            int tongtien = Convert.ToInt32(txttongtien.Text);
            hoadonDAO.Instance.suaHD(mahd, manv, makh, giamgia, ngayban, tongtien, trangthai);
            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reset();
            load();
        }

        private void btnxoahd_Click(object sender, EventArgs e)
        {
            if (cbbmakh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbmakh.Focus();
                return;
            }
            string mahd = txt_mahd.Text;
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                hoadonDAO.Instance.xoaHD(mahd);
                reset();
                load();
            } 
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
           
            if (chkTT.Checked == false)
            {
                string mahd = txt_mahd.Text;
                int tong = Convert.ToInt32(txttongtien.Text);
                string tt;
                chkTT.Checked = true;
                tt = "Đã Thanh Toán";
                string trangthai = tt;
                if (MessageBox.Show("Bạn có muốn thanh toán không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    hoadonDAO.Instance.ThanhToan(mahd, tong, trangthai);
                    reset();
                    load();
                }
            }
        }
        void resetcthd()
        {
            string qr = "exec HOADONCT_TUTANGID";
            DataTable dtt = DataProvider.Instance.ExecuteQuery(qr);
            txtmacthd.Text = dtt.Rows[0][0].ToString();
            cbbmahct.Text = "";
            cbbmasp.Text = "";
            nmrsoluong.Value = 0;
            cbbdongia.Text = "";
            txtthanhtien.Text = "0";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            string query = "select soluong from sanpham where masp ='" + cbbmasp.SelectedValue.ToString() + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            int soluongg = Convert.ToInt32(dt.Rows[0][0].ToString());
            int sl = (int)nmrsoluong.Value;
            if (sl > soluongg)
            {
                MessageBox.Show("Số Lượng Chỉ Còn: "+soluongg, "Thông Báo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nmrsoluong.Maximum = soluongg;
            }
            else
            {
                string macthd = txtmacthd.Text;
                string mahd = cbbmahct.SelectedValue.ToString();
                string masp = cbbmasp.SelectedValue.ToString();
                int soluong = (int)nmrsoluong.Value;
                int dongia = (int)cbbdongia.SelectedValue;
                int thanhtien = Convert.ToInt32(txtthanhtien.Text);
                CTHD_DAO.Instace.themCTHD(macthd, mahd, masp, soluong, dongia, thanhtien);
                hoadonDAO.Instance.capnhatsoluong(masp, soluong);
                resetcthd();
                loadcthd();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (cbbmahct.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbmahct.Focus();
                return;
            }
            string macthd = txtmacthd.Text;
            string mahd = cbbmahct.SelectedValue.ToString();
            string masp = cbbmasp.SelectedValue.ToString();
            int soluong = (int)nmrsoluong.Value;
            int dongia = (int)cbbdongia.SelectedValue;
            int thanhtien = Convert.ToInt32(txtthanhtien.Text);
            CTHD_DAO.Instace.suaCTHD(macthd, mahd, masp, soluong, dongia, thanhtien);
            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetcthd();
            loadcthd();
        }

        private void dgv_cthd_Click(object sender, EventArgs e)
        {
            txtmacthd.Text = dgv_cthd.CurrentRow.Cells["macthd"].Value.ToString();
            cbbmahct.Text = dgv_cthd.CurrentRow.Cells["mahdd"].Value.ToString();
            cbbmasp.Text = dgv_cthd.CurrentRow.Cells["masp"].Value.ToString();
            cbbdongia.Text = dgv_cthd.CurrentRow.Cells["dongia"].Value.ToString();
            nmrsoluong.Text = dgv_cthd.CurrentRow.Cells["soluong"].Value.ToString();
            txtthanhtien.Text = dgv_cthd.CurrentRow.Cells["thanhtien"].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (cbbmahct.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbmahct.Focus();
                return;
            }
            string macthd = txtmacthd.Text;
            int soluong = (int)nmrsoluong.Value;
            string masp = cbbmasp.SelectedValue.ToString();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CTHD_DAO.Instace.xoaCTHD(macthd);
                hoadonDAO.Instance.capnhatxoasoluong(masp, soluong);
                resetcthd();
                loadcthd();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = "select*from hoadon where mahd like '%" +txttimkiem.Text.Trim()+"%'";
            dgv_hoadon.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            if (cbbmakh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn cần in!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbmakh.Focus();
                return;
            }
            //khởi động excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //trong 1 ctrinh excel có nhiều workbook
            COMExcel.Worksheet exSheet; //trong 1 workbook có nhiều worksheet
            COMExcel.Range exRange;
            string query;
            int hang = 0, cot = 0;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            //định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //XANH DA TRỜI
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop TIN3 BEAUTY";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Ninh Kiều - Cần Thơ";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (84)343745238";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            query = "select MAHD, NGAYBAN, TONGTIEN, TENKH, KHACHHANG.DIACHI, KHACHHANG.SDT, TENNV FROM HOADON, KHACHHANG, NHANVIEN WHERE HOADON.MAKH = KHACHHANG.MAKH AND HOADON.MANV = NHANVIEN.MANV AND MAHD = '" + txt_mahd.Text + "'";
            DataTable dthd = DataProvider.Instance.ExecuteQuery(query);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = dthd.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = dthd.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = dthd.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = dthd.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            string queryy = "select TENSP, CTHD.SOLUONG, DONGIA, GIAMGIA, THANHTIEN FROM SANPHAM, HOADON, CTHD WHERE  SANPHAM.MASP=CTHD.MASP AND HOADON.MAHD=CTHD.MAHD AND HOADON.MAHD ='" + txt_mahd.Text + "'";
            DataTable cthd = DataProvider.Instance.ExecuteQuery(queryy);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["B11:B11"].ColumnWidth = 40;
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < cthd.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < cthd.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = cthd.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = cthd.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = dthd.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            DateTime d = Convert.ToDateTime(dthd.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "CẦN THƠ, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = dthd.Rows[0][6];
            exSheet.Name = "Hóa đơn";
            exApp.Visible = true;
        }

    }
}
 
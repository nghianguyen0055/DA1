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
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QLSMP
{
    public partial class f_thongke : Form
    {
        public f_thongke()
        {
            InitializeComponent();
            loaddatetime();
            loadngay(dtpk_fromdate.Value, dtpk_todate.Value);
            tongcong();
        }
        
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region methods
        void loadngay(DateTime tungay, DateTime denngay)
        {
            dgv_doanhthu.DataSource = hoadonDAO.Instance.thongke(tungay, denngay);
        }
        void loaddatetime()
        {
            DateTime today = DateTime.Now;
            dtpk_fromdate.Value = new DateTime(today.Year, today.Month, 1);
            dtpk_todate.Value = dtpk_fromdate.Value.AddMonths(1).AddDays(-1);
        }
            #endregion
        private void btn_thongke_Click(object sender, EventArgs e)
        {
            loadngay(dtpk_fromdate.Value, dtpk_todate.Value);
            tongcong();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttongcong.Text != "0")
            {
                COMExcel.Application exApp = new COMExcel.Application();
                COMExcel.Workbook exBook; //trong 1 ctrinh excel có nhiều workbook
                COMExcel.Worksheet exSheet; //trong 1 workbook có nhiều worksheet
                COMExcel.Range exRange;
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
                exRange.Range["C2:E2"].Value = "THỐNG KÊ";
                // Biểu diễn thông tin chung của hóa đơn bán
                DateTime tungay = dtpk_fromdate.Value;
                DateTime dengay = dtpk_todate.Value;
                DataTable dt = hoadonDAO.Instance.INthongke(tungay, dengay);
                exRange.Range["A6:F6"].Font.Bold = true;
                exRange.Range["A6:F6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C6:F6"].ColumnWidth = 12;
                exRange.Range["A6:A6"].Value = "STT";
                exRange.Range["B6:B6"].Value = "Tên Khách Hàng";
                exRange.Range["B6:B6"].ColumnWidth = 30;
                exRange.Range["C6:C6"].Value = "Ngày Bán";
                exRange.Range["C6:C6"].ColumnWidth = 20;
                exRange.Range["D6:D6"].Value = "Tổng Tiền";
                for (hang = 0; hang < dt.Rows.Count; hang++)
                {
                    //Điền số thứ tự vào cột 1 từ dòng 12
                    exSheet.Cells[1][hang + 7] = hang + 1;
                    for (cot = 0; cot < dt.Columns.Count; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    {
                        DateTime d = Convert.ToDateTime(dt.Rows[0][1]);
                        exSheet.Cells[cot + 2][hang + 7] = dt.Rows[hang][cot].ToString();
                        if (cot == 3) exSheet.Cells[cot + 2][hang + 7] = dt.Rows[hang][cot].ToString();
                    }
                }
                exRange = exSheet.Cells[cot - 2][hang + 14];
                exRange.Font.Bold = true;
                exRange.ColumnWidth = 20;
                exRange.Value2 = "TỔNG CỘNG:";
                exRange = exSheet.Cells[cot - 1][hang + 14];
                exRange.Font.Bold = true;
                exRange.Value2 = "=SUM($D:$D)";
                exSheet.Name = "Thống Kê";
                exApp.Visible = true;
            }
            else
                MessageBox.Show("Không có hóa đơn cần in!!!","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }
        void tongcong()
        {
            DateTime tungay = dtpk_fromdate.Value;
            DateTime dengnay = dtpk_todate.Value;
            string query = "select dbo.tongtien( '"+dtpk_fromdate.Value+"' , '"+dtpk_todate.Value+"') ";
            int tong= (int)DataProvider.Instance.ExecuteScalar(query, new object[] { tungay, dengnay });
            txttongcong.Text = tong.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DAO
{
    public class hdnDAO
    {
        private static hdnDAO instance;

        public static hdnDAO Instance {
            get { if (instance == null) instance = new hdnDAO(); return instance; }
           private set { instance = value; }
        }
        private hdnDAO() {  }

        public void themHDN(string mahdn, string manv, string masp, string mancc, int soluong, DateTime ngaynhap, string diachi, string sdt, int gia, int tongtien)
        {
            string query = "exec THEMhdn @MAHDN , @MANV , @MASP , @MANCC , @SOLUONG , @NGAYNHAP , @DIACHI , @SDT ,  @GIA , @TONGTIEN";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahdn, manv, masp, mancc, soluong, ngaynhap, diachi, sdt, gia, tongtien });
        }
        public void suaHDN(string mahdn, string manv, string masp, string mancc, int soluong, DateTime ngaynhap, string diachi, string sdt, int gia, int tongtien)
        {
            string query = "SUAHDN @MAHDN , @MANV , @MASP , @MANCC , @SOLUONG , @NGAYNHAP , @DIACHI , @SDT ,  @GIA , @TONGTIEN ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahdn, manv, masp, mancc, soluong, ngaynhap, diachi, sdt, gia, tongtien });
        }
        public void xoaHDN(string mahdn)
        {
            string query = "exec XOAHDN @MAHDN";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahdn });
        }
    }
}

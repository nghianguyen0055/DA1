using QLSMP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DAO
{
    public class hoadonDAO
    {
        private static hoadonDAO instance;

        public static hoadonDAO Instance
        {
            get { if (instance == null) instance = new hoadonDAO(); return instance; }
            private set { instance = value; }
        }
        private hoadonDAO() { }

        public List<hoadon> layhd(){
            List<hoadon> ls = new List<hoadon>();
            string query = "select*from hoadon";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                hoadon hd = new hoadon(item);
                ls.Add(hd);
            }
            return ls;
            }

        public void themHD(string mahd, string manv, string makh, int khuyenmai, DateTime ngayban, int tongtien, string trangthai)
        {
            string query = "exec THEMHD @MAHD , @MANV , @MAKH , @GIAMGIA , @NGAYBAN , @TONGTIEN , @TRANGTHAI";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahd, manv, makh, khuyenmai, ngayban, tongtien, trangthai });
        }
        public void suaHD(string mahd, string manv, string makh, int khuyenmai, DateTime ngayban, int tongtien, string trangthai)
        {
            string query = "exec SUAHD @MAHD , @MANV , @MAKH , @GIAMGIA , @NGAYBAN , @TONGTIEN , @TRANGTHAI ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahd, manv, makh, khuyenmai, ngayban, tongtien, trangthai });
        }
        public void xoaHD(string mahd)
        {
            string query = "exec XOAHD @MAHD ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahd });
        }
        public void ThanhToan(string mahd, int tongtien, string trangthai)
        {
            string query = "exec THANHTOAN @MAHD , @TONGTIEN , @TRANGTHAI  ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mahd, tongtien, trangthai });
        }

        public DataTable thongke(DateTime tungay, DateTime denngay) 
        {
            return DataProvider.Instance.ExecuteQuery("exec THONGKE @TUNGAY , @DENNGAY ", new object[] { tungay, denngay});
        }
        public DataTable INthongke(DateTime tungay, DateTime denngay)
        {
            return DataProvider.Instance.ExecuteQuery("exec inthongke @TUNGAY , @DENNGAY ", new object[] { tungay, denngay });
        }
        public void capnhatsoluong(string masp, int soluongmoi)
        {
            string querry = "exec UPDATETHEMSP @MASP , @SOLUONGMOI ";
            DataProvider.Instance.ExecuteQuery(querry, new object[] { masp, soluongmoi });
        }
        public void capnhatxoasoluong(string masp, int soluongmoi)
        {
            string query = "exec UPDATExoasp @MASP , @SOLUONGMOI ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { masp, soluongmoi });
        }
        
    }
}

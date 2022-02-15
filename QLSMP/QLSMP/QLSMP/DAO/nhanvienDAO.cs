using QLSMP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DAO
{
    public class nhanvienDAO
    {
        private static nhanvienDAO instance;

        public static nhanvienDAO Instance
        {
            get { if (instance == null) instance = new nhanvienDAO(); return instance; }
            private set { instance = value; }
        }
        private nhanvienDAO() { }

        public void themNV(string manv, string tennv, string gioitinh, string diachi, string sdt)
        {
            string query = "THEMNV @MANV , @TENNV , @GIOITINH , @DIACHI , @SDT ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { manv, tennv, gioitinh, diachi, sdt });
        }
        public void suaNV(string manv, string tennv, string gioitinh, string diachi, string sdt)
        {
            string qr = "EDITNV @MANV , @TENNV , @GIOITINH , @DIACHI , @SDT ";
            DataProvider.Instance.ExecuteNonQuery(qr, new object[] { manv, tennv, gioitinh, diachi, sdt });
        }
        public void xoaNV(string manv)
        {
            string query = "DELETENV @MANV ";
            DataProvider.Instance.ExecuteNonQuery(query,new object[] { manv});
        }
        public List<NHANVIEN> laynv()
        {
            List<NHANVIEN> ls = new List<NHANVIEN>();
            string query = "select*from nhanvien";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                NHANVIEN nhanvien = new NHANVIEN(item);
                ls.Add(nhanvien);
            }
            return ls;
        }

    }
}

using QLSMP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DAO
{
    public class sanphamDAO
    {
        private static sanphamDAO instance;

        public static sanphamDAO Instance 
        {
            get { if (instance == null) instance = new sanphamDAO(); return instance; }
            private set { instance = value; }
        }
        private sanphamDAO() { }

        public void themSP(string masp, string tensp, string mancc, string maloaii, int soluong, float gia)
        {
            string querey = "EXEC THEMsanpham @MASP , @TENSP , @MANCC , @MALOAI , @SOLUONG , @GIA ";
            DataProvider.Instance.ExecuteNonQuery(querey, new object[] { masp, tensp, mancc, maloaii, soluong, gia });
        }
        public void suaSP(string masp, string tensp, string mancc, string maloaii, int soluong, float gia)
        {
            string query = "exec EDITSP @MASP  , @TENSP , @MANCC , @MALOAI , @SOLUONG , @GIA ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { masp, tensp, mancc, maloaii, soluong, gia });
        }
        public void xoaSP(string masp)
        {
            string query = "DELETESP @MASP ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { masp });
        }

        public List<sanpham> laysp()
        {
            List<sanpham> ls = new List<sanpham>();
            string query = "select*from sanpham";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                sanpham sp = new sanpham(item);
                ls.Add(sp);
            }
            return ls;
        }
        public List<sanpham> layspquaMASP(int gia)
        {
            List<sanpham> ls = new List<sanpham>();
            string query = "select * from sanpham where gia= " + gia;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                sanpham sp = new sanpham(item);
                ls.Add(sp);
            }

            return ls;
        }
    }
}

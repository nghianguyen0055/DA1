using QLSMP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DAO
{
    public class LoaiDAO
    {
        private static LoaiDAO instance;

        public static LoaiDAO Instance
        {
            get { if (instance == null) instance = new LoaiDAO(); return instance; }
            private set { instance = value;}
        }
        private LoaiDAO() { }

        public void insertloai(string maloai, string tenloai)
        {
            string query = "USP_THEMLOAI @MALOAI , @TENLOAI ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { maloai, tenloai });
        }
        public void editLoai(string maloai, string tenloai)
        {
            string query = "EDITLOAI @MALOAI , @TENLOAI";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { maloai, tenloai });
        }

        public void deleteLoai(string maloai)
        {
            string query = "DELETELOAI @MALOAI ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { maloai });
        }

        public List<LOAI> layloai()
        {
            List<LOAI> ls = new List<LOAI>();
            string query = "select *from loai";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                LOAI loai = new LOAI(item);
                ls.Add(loai);
            }
            return ls;
        }
    }
}

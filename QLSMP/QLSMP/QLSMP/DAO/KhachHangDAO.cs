using QLSMP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DAO
{
   public  class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set { instance = value; }
        }
        private KhachHangDAO() { }

        public void insertKH(string makh, string tenkh, string gioitinh, string diachi, string sdt)
        {
            string query = "USP_THEMKH @MAKH , @TENKH , @GIOITINH , @DCHI , @SDT ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { makh, tenkh, gioitinh, diachi, sdt });
        }

        public void editKH(string makh, string tenkh, string gioitinh, string diachi, string sdt)
        {
            string query = "EDITKH @MAKH , @TEN , @GIOITINH , @DIACHI , @SDT ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { makh, tenkh, gioitinh, diachi, sdt});
        }
        public void deleteKH(string makh) 
            {
            string query = "DELETEKH @MAKH ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { makh});
            } 
        public List<khachhang> laykh()
        {
            List<khachhang> listkh = new List<khachhang>();
            string query = "select*from khachhang";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                khachhang kh = new khachhang(item);
                listkh.Add(kh);
            }
            return listkh;
        }

    }
}

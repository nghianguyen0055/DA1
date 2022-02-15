using QLSMP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DAO
{
   public  class NccDAO
    {
        private static NccDAO instance;

        public static NccDAO Instance 
        {
            get { if (instance == null) instance = new NccDAO(); return instance;  }
            private set { instance = value; }
        }
        private NccDAO() { }

        public void themNCC(string mancc, string tenncc, string diachi, string sdt)
        {
            string query = "THEMNCC @MANCC , @TENNCC , @DIACHI , @SDT ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { mancc, tenncc, diachi, sdt });
        }
        public void suaNCC(string mancc, string tenncc, string diachi, string sdt)
        {
            string qr = "EDITNCC @MANCC , @TENNCC , @DIACHI , @SDT ";
            DataProvider.Instance.ExecuteNonQuery(qr, new object[] { mancc, tenncc, diachi, sdt });
        }
        public void xoaNCC(string mancc)
        {
            string qr = "DELETENCC @MANCC";
            DataProvider.Instance.ExecuteNonQuery(qr, new object[] { mancc});
        }

        public List<NCC> layncc()
        {
            List<NCC> ls = new List<NCC>();
            string query = "select*from nhacungcap";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                NCC ncc = new NCC(item);
                ls.Add(ncc);
            }
            return ls;
        }

    }
}

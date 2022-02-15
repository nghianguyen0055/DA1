using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if(instance==null) instance=new TaiKhoanDAO(); return instance; }
           private set { instance = value; }
        }
        private TaiKhoanDAO() { }


        public void themTK(string username, string matkhau, string quyen)
        {
            string query = "THEMTK @USER , @MATKHAU , @quyen ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, matkhau, quyen });
        }

        public void suaTK(string username, string matkhau, string quyen)
        {
            string query = "EDITTK @USER  , @MATKHAU , @QUYEN ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, matkhau, quyen });
        }

        public void xoaTK(string username)
        {
            string query = " DELETETK @user ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { username });
        }
    }
}

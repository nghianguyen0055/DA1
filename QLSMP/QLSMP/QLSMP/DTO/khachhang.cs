using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DTO
{
    public class khachhang
    {
        public khachhang(string makh, string tenkh, string gioitinh, string diachi, string sdt)
        {
            this.Makh = makh;
            this.Tenkh = tenkh;
            this.Gioitinh = gioitinh;
            this.Diachi = diachi;
            this.Sdt = sdt;
        }
        public khachhang(DataRow row)
        {
            this.Makh = row["makh"].ToString();
            this.Tenkh = row["tenkh"].ToString();
            this.Gioitinh = row["gioitinh"].ToString();
            this.Diachi = row["diachi"].ToString();
            this.Sdt = row["sdt"].ToString();
        }


        private string makh;
        private string tenkh;
        private string gioitinh;
        private string diachi;
        private string sdt;

        public string Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}

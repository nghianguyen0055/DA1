using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DTO
{
    public class hoadon
    {
        public hoadon(string mahd, string manv, string makh, DateTime? ngayhd, string trangthai, int? tongtien)
        {
            this.Mahd = mahd;
            this.Manv = manv;
            this.Makh = makh;
            this.Ngayhd = ngayhd;
            this.Trangthai = trangthai;
            this.Tongtien = tongtien;
        }

        public hoadon(DataRow row)
        {
            this.Mahd = row["mahd"].ToString();
            this.Manv = row["manv"].ToString();
            this.Makh = row["makh"].ToString();
            this.Ngayhd = (DateTime?)row["ngayban"]; 
            this.Trangthai = row["trangthai"].ToString();
            this.Tongtien = (int?)row["TONGTIEN"];
        }



        private string mahd;
        private string manv;
        private string makh;
        private DateTime? ngayhd;
        private string trangthai;
        private int? tongtien;

        public string Mahd { get => mahd; set => mahd = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Makh { get => makh; set => makh = value; }
        public DateTime? Ngayhd { get => ngayhd; set => ngayhd = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public int? Tongtien { get => tongtien; set => tongtien = value; }
    }
}

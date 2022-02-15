using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DTO
{
   public class NHANVIEN
    {
        public NHANVIEN(string manv, string tennv, string gioitinh, string diachi, string sdt)
        {
            this.Manv = manv;
            this.Tennv = tennv;
            this.Gioitinh = gioitinh;
            this.Diachi = diachi;
            this.Sdt = sdt;
        }
        public NHANVIEN(DataRow row)
        {
            this.Manv = row["manv"].ToString();
            this.Tennv = row["tennv"].ToString();
            this.Gioitinh = row["gioitinh"].ToString();
            this.Diachi = row["diachi"].ToString();
            this.Sdt = row["sdt"].ToString();
        }




        private string manv;
        private string tennv;
        private string gioitinh;
        private string diachi;
        private string sdt;


        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}

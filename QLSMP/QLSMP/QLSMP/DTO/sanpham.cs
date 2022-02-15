using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DTO
{
    public class sanpham
    {
        public sanpham(string masp, string tensp, string mancc, string maloai, int gia, int soluong)
        {
            this.Masp = masp;
            this.Tensp = tensp;
            this.Mancc = mancc;
            this.Maloai = maloai;
            this.Gia = gia;
            this.Soluong = soluong;
        }
        public sanpham(DataRow row)
        {
            this.Masp = row["masp"].ToString();
            this.Tensp = row["tensp"].ToString();
            this.Mancc = row["mancc"].ToString();
            this.Maloai = row["maloai"].ToString();
            this.Gia = (int)row["gia"];
            this.Soluong = (int)row["soluong"];
        }



        private string masp;
        private string tensp;
        private string mancc;
        private string maloai;
        private int gia;
        private int soluong;

        public string Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public string Mancc { get => mancc; set => mancc = value; }
        public string Maloai { get => maloai; set => maloai = value; }
        public int Gia { get => gia; set => gia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
    }
}

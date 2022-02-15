using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DTO
{
    public class LOAI
    {
        public LOAI(string maloai, string tenloai)
        {
            this.Maloai = maloai;
            this.Tenloai = tenloai;
        }
        public LOAI(DataRow row)
        {
            this.Maloai = row["MALOAI"].ToString();
            this.Tenloai = row["tenloai"].ToString();
        }



        private string maloai;

        public string Maloai { get => maloai; set => maloai = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }

        private string tenloai;
    }
}
